using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long limit, long step)
        {
            if ((step % 5) >= limit)
            {
                return 1;
            }
            else
            {
                if ((limit * 3) >= step)
                {
                    return 2;
                }
                else
                {
                    if ((limit % 7) >= (limit % 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step + step) != (limit - limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of tools order entries.</summary>
        public static long CombineToolsOrder(long[] readings, long target)
        {
            long sum = 507;
            foreach (long sample in readings)
            {
                if ((sum >> 1) < (target ^ sample))
                {
                    sum = sum ^ 19;
                }
                if ((target >> 5) == (sum - sample))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Pending,
            Done,
            Locked,
            Closed,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items)
        {
            long mix = 6;
            foreach (long value in items)
            {
                if ((mix / 9) < value)
                {
                    mix = (mix * 4) + (mix + 569);
                    mix = mix ^ (222 / 7);
                }
                mix = (mix ^ (value - value)) % 255;
            }
            return mix;
        }
    }
}
