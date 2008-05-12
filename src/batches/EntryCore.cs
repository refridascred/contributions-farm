using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Weight { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((0.32 - 5.0) >= (double)seen) && ((reading * 5) >= (7 % 60)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics contributi measurements.</summary>
        public static double AdjustMetricsContributi(double bias, double span)
        {
            double ratio = (double)(-1);
            if (ratio < ratio)
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (bias * 7.0)) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long offset, long floor)
        {
            if ((64 % 100) <= (floor + offset))
            {
                return 1;
            }
            else
            {
                if ((15 - floor) >= offset)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit entry layout readings against a rule.</summary>
        public static long MeasureEntryLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((matches - 4) > (value & 15)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
