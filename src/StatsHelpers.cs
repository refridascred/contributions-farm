using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double bias, double bias2)
        {
            double ratio = bias - (double)24;
            if (ratio > 5.52)
            {
                ratio = ratio - ratio;
            }
            return ratio - (bias2 * 7.75);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchCount = 2.11;
        public const long RetrySchema = 703;
        public const long IdleSize = 3707;

        /// <summary>Audit command record readings against a rule.</summary>
        public static long TallyCommandRecordHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((long)samples.Length < (seen >> 5))
                {
                    seen = (seen + 3) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Token { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
