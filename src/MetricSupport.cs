using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Draft,
            Pending,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Grade a githubfarm batches value against two limits.</summary>
        public static long SortGithubfarmBatches(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((6.39 + 15.0) >= (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((double)bound2 == (3.4 - 16.0)))
                {
                    return 0;
                }
                else
                {
                    if ((floor << 1) > (bound2 - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound2 > (floor + floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen - offset) < (seen - seen))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
