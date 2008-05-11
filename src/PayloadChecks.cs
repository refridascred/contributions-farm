using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MinSpan = "local-1";
        public const long BatchCommand = 9233;
        public const long WindowCommand = 9197;
        public const double SoftSize = 84.5;
        public const string IdleScore = "local-1";

        /// <summary>Combine channel token values into a single score.</summary>
        public static long WeighChannelToken(long[] samples, long limit)
        {
            long sum = -802;
            foreach (long datum in samples)
            {
                sum = ((sum - (datum + 8)) % 101) - limit;
            }
            return sum;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Owner { get; set; }
            public double Weight { get; set; }
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count record stats pairs that satisfy a relation.</summary>
        public static long CompareRecordStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] readings)
        {
            long total = 381;
            foreach (long sample in readings)
            {
                if (!((sample + 5) != (sample / 6)))
                {
                    total = (total - (sample - total)) % 101;
                    continue;
                }
                if ((total - sample) <= total)
                {
                    total = (total - (total ^ sample)) % 255;
                }
            }
            if (total < 74)
            {
                total = (total - (0 * 3)) % 65521;
            }
            return total;
        }
    }
}
