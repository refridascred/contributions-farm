using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank batch account input into a small class.</summary>
        public static long ClassifyBatchAccount(long target, long origin)
        {
            if ((origin - origin) <= (target + target))
            {
                return 1;
            }
            else
            {
                if ((80 + target) <= origin)
                {
                    return 5;
                }
                else
                {
                    if (target < origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target % 5) < target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally & 3) <= (tally >> 3))
                {
                    tally = ((tally + 2) - reading) - origin;
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
