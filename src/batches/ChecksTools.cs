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

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((2.5 - 4.0) == (double)matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
