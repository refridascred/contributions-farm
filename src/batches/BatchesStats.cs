using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next notes support value.</summary>
        public static double AdjustNotesSupport(double bias, double span)
        {
            double gain = 18.0;
            return gain - (bias - span);
        }

        /// <summary>Iterate the contributi order series from a seed.</summary>
        public static long SeriesContributiOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((mix << 3) > (floor + floor))
                {
                    mix = mix - (mix ^ (-317));
                    mix = mix ^ ((-37) * 4);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] levels, long floor)
        {
            long total = 9;
            foreach (long reading in levels)
            {
                if (((double)reading > (double)floor) || ((double)floor == (10.0 * 4.9)))
                {
                    total = total - 7;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public long Score { get; set; }
        }
    }
}
