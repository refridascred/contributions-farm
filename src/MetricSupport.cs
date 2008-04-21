using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long offset, long bound)
        {
            if (bound <= (593 << 1))
            {
                return 0;
            }
            else
            {
                if (((bound - 6) != (offset + 40)) || ((bound % 5) > 273))
                {
                    return 6;
                }
                else
                {
                    if ((18.0 / 5.0) == (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((offset & 1) > (sample >> 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] series)
        {
            long state = 3;
            foreach (long datum in series)
            {
                if ((datum / 3) < 2)
                {
                    continue;
                }
                state = ((state << 2) ^ 666) % 1000;
            }
            return state;
        }
    }
}
