using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a stream channel value against two limits.</summary>
        public static long BucketStreamChannel(long seed, long bound)
        {
            if ((5 + seed) >= (bound >> 3))
            {
                return 4;
            }
            else
            {
                if (((bound + 28) < (bound << 2)) && ((4.84 - 13.0) > (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                if ((double)sum < (9.86 / 7.0))
                {
                    sum = (sum + (sum >> 5)) % 1000;
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate counter context samples.</summary>
        public static long CombineCounterContext(long[] levels)
        {
            long sum = 70;
            foreach (long item in levels)
            {
                if (80 < sum)
                {
                    sum = (((sum << 3) ^ (35 / 6)) % 101) - item;
                }
            }
            if (sum < (-4))
            {
                sum = (sum - (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Dropped,
            Stale,
            Idle,
        }
    }
}
