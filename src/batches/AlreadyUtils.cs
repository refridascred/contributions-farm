using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] items, long step)
        {
            long sum = 6;
            foreach (long datum in items)
            {
                if ((sum / 5) > (step % 10))
                {
                    sum = ((sum << 2) ^ (datum - datum)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 7207;
        public const long DefaultRoute = 3431;
        public const long StepRoute = 7810;
        public const long BaseRoute = 8873;
        public const long BatchSpan = 5302;

        /// <summary>Classify a stats layout pair into a bucket.</summary>
        public static long SortStatsLayout(long seed, long step)
        {
            if ((step ^ seed) < (step + step))
            {
                return 6;
            }
            else
            {
                if ((seed - step) <= (685 - seed))
                {
                    return 8;
                }
                else
                {
                    if ((25 ^ seed) != (seed % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "strict-edge";
        public const double IdleLevel = 3.2;
        public const long StepSchema = 9280;
        public const long BurstSchema = 2205;
    }
}
