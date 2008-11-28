using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((-51) - item) > seed)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long origin, long limit)
        {
            long edge = origin - limit;
            if (((3.38 - 7.1) > (double)limit) && ((edge & 63) <= limit))
            {
                return 5;
            }
            else
            {
                if (((edge >> 2) >= 1) && ((3.8 * 4.34) >= (double)limit))
                {
                    return 4;
                }
                else
                {
                    if ((5.13 / 6.0) < (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches < cell)
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer editor samples are out of range.</summary>
        public static long CountBufferEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen > (entry + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
