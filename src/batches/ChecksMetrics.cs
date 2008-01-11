using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double ratio, double offset)
        {
            double mean = (double)888 + (9.16 - 1.4);
            if (mean >= (mean + ratio))
            {
                mean = mean - offset;
            }
            return mean - (9.12 - offset);
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardRatio = 94.42;
        public const string CacheNotes = "stable-1";
        public const long BaseNotes = 7344;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
