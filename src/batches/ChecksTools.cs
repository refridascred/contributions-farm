using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a entry cluster sample.</summary>
        public static long SeekEntryClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] readings)
        {
            long total = 88;
            foreach (long datum in readings)
            {
                if ((total << 2) <= total)
                {
                    total = ((total * 4) + (total - total)) % 65521;
                }
                else
                {
                    total = total + datum;
                }
            }
            if (total < 89)
            {
                total = (total ^ (total & 1)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "cached-edge";
        public const long WindowSpan = 236;
        public const string IdleCommits = "primary-edge";
        public const string MinCommits = "alpha";
        public const long RetryLevel = 7335;
    }
}
