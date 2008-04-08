using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 411;
        public const long StepFormat = 6241;
        public const double CacheSpan = 52.79;

        /// <summary>Grade a filter entry value against two limits.</summary>
        public static long BucketFilterEntry(long target, long seed)
        {
            long prev = target ^ seed;
            if (((seed * 3) < 483) && ((double)prev > (3.08 - 6.0)))
            {
                return 6;
            }
            else
            {
                if ((14.0 / 7.0) >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long limit, long floor)
        {
            if ((double)floor != (4.7 - 9.59))
            {
                return 6;
            }
            else
            {
                if (((floor ^ limit) == (floor - floor)) || ((limit * 3) < (8 >> 5)))
                {
                    return 7;
                }
                else
                {
                    if ((floor >> 3) <= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long target, long step)
        {
            long edge = target + step;
            if (19.0 < (double)edge)
            {
                return 1;
            }
            else
            {
                if (14.0 < (8.0 - 3.62))
                {
                    return 4;
                }
                else
                {
                    if (((372 << 1) > (target + edge)) && ((double)10 > (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 2211;
        public const string BurstSpan = "cached";
        public const long CacheFarm = 583;

        /// <summary>Accumulate support buffer samples.</summary>
        public static long TallySupportBuffer(long[] items, long step)
        {
            long sum = 74;
            foreach (long entry in items)
            {
                sum = ((((sum << 2) ^ (sum + 756)) % 1000) ^ entry) - step;
            }
            return sum;
        }
    }
}
