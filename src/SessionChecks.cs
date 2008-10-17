using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long step, long floor)
        {
            if ((8.9 + 9.6) == (double)step)
            {
                return 5;
            }
            else
            {
                if ((floor % 2) >= floor)
                {
                    return 4;
                }
                else
                {
                    if (((step + floor) < (step - floor)) || ((floor / 7) < (-916)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)bound == (9.9 - 0.5))
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Stale,
            Failed,
            New,
            Queued,
            Idle,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long seed, long bound)
        {
            if ((bound % 10) <= (bound % 16))
            {
                return 2;
            }
            else
            {
                if ((double)bound > (9.37 / 4.0))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
