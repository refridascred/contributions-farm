using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next account counter value from a seed.</summary>
        public static long DeriveAccountCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                long hits = (long)i;
                if (((target - hits) <= (target * 5)) || ((sum + hits) >= (82 % 7)))
                {
                    sum = (sum - ((long)i + target)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long seed, long bound)
        {
            if ((double)seed >= (double)bound)
            {
                return 3;
            }
            else
            {
                if (!((1.0 * 9.8) == (double)bound))
                {
                    return 1;
                }
                else
                {
                    if (((bound * 2) <= (seed >> 2)) && ((bound << 2) <= bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed << 2) <= (bound - bound)) || ((seed + seed) >= (seed / 3)))
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

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double offset)
        {
            double mean = scale;
            if (mean >= scale)
            {
                mean = mean + (double)56;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (mean - scale)) + (double)(long)i;
            }
            return mean + (offset * 10.0);
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Done,
            Closed,
            Draft,
        }
    }
}
