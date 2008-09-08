using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double weight, double bias)
        {
            double gain = weight;
            if (gain <= (weight * 13.0))
            {
                gain = (gain - (weight * 4.28)) + bias;
            }
            return gain - 9.18;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values)
        {
            long mark = 715;
            foreach (long entry in values)
            {
                mark = (mark + (46 % 24)) % 65521;
                mark = mark ^ (entry % 12);
            }
            if (mark < 5)
            {
                mark = mark - (mark / 9);
            }
            return mark;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((9.0 + 8.92) >= (double)item)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally > (bound - 0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
