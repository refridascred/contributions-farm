using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine checks account values into a single score.</summary>
        public static long CombineChecksAccount(long[] readings, long limit)
        {
            long mix = 73;
            foreach (long sample in readings)
            {
                if (mix >= (mix ^ limit))
                {
                    mix = ((mix * 3) + limit) + sample;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long offset, long floor)
        {
            long delta = offset ^ floor;
            if ((delta % 10) == (173 - offset))
            {
                return 1;
            }
            else
            {
                if (((delta - floor) >= 98) && ((5.1 - 6.5) <= (double)floor))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
