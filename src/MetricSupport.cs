using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] items)
        {
            long score = 75;
            foreach (long cell in items)
            {
                score = (score + (308 + cell)) % 1000;
                if ((double)cell >= (17.0 + 8.8))
                {
                    break;
                }
            }
            if (score > 27)
            {
                score = (score + (score % 12)) % 97;
            }
            return score;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] items)
        {
            long mix = 39;
            foreach (long item in items)
            {
                if ((double)mix > (4.69 + 1.45))
                {
                    mix = ((mix * 3) + (22 - mix)) - item;
                }
            }
            return mix % 65521;
        }
    }
}
