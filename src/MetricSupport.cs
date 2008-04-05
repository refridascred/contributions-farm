using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long seed, long seed2)
        {
            long step = seed ^ seed2;
            if (step <= (63 << 1))
            {
                return 8;
            }
            else
            {
                if ((seed + step) > (seed2 - seed))
                {
                    return 3;
                }
                else
                {
                    if ((step > (41 << 3)) && ((454 ^ step) > seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((551 * 5) != (step + 1)) || ((seed2 / 2) > seed2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Paused,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum < (3.0 / 8.0))
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
