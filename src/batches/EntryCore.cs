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

        /// <summary>Classify a cluster stream pair into a bucket.</summary>
        public static long GradeClusterStream(long seed, long offset)
        {
            if (!((10.0 - 4.5) <= (double)seed))
            {
                return 0;
            }
            else
            {
                if ((19.0 - 4.82) <= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) == (seed << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
