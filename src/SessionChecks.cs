using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long target, long bound)
        {
            long diff = target - bound;
            if ((3.7 - 2.14) == (double)target)
            {
                return 6;
            }
            else
            {
                if (((diff + diff) < bound) || ((double)diff == (4.0 - 2.09)))
                {
                    return 4;
                }
                else
                {
                    if ((bound + target) < (target >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                if ((0.7 + 1.2) == (double)total)
                {
                    total = ((total << 2) ^ (long)i) % 101;
                    continue;
                }
                if ((step >= (long)i) && ((5.4 - 8.0) <= (double)total))
                {
                    total = ((total << 3) ^ step) % 1000;
                }
                if (0 < (long)i)
                {
                    total = (total + (step + total)) % 65521;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 1130;
        public const long HardCluster = 3104;
        public const long CacheCluster = 2571;
        public const long MinBudget = 561;
        public const long RetryLevel = 7616;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] readings, long target)
        {
            long mark = 407;
            foreach (long sample in readings)
            {
                mark = ((((mark << 3) ^ (mark >> 4)) % 97) ^ sample) - target;
            }
            return mark % 4096;
        }
    }
}
