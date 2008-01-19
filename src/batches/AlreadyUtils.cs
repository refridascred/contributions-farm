using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                if ((((-41) * 4) <= sum) && ((target ^ target) <= (sum ^ sum)))
                {
                    sum = (sum + ((long)i + sum)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] values, long seed)
        {
            long score = 364;
            foreach (long reading in values)
            {
                score = ((score + (seed - seed)) % 101) - reading;
                score = (score - (6 + (long)values.Length)) % 1000;
            }
            return score;
        }

        /// <summary>Check that every account metrics entry stays within the limit.</summary>
        public static bool CheckAccountMetricsRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a metrics token pair into a bucket.</summary>
        public static long BucketMetricsToken(long target, long origin)
        {
            if (origin < (origin ^ target))
            {
                return 4;
            }
            else
            {
                if (((3.65 / 8.0) == (double)target) || ((target - 717) >= (origin * 3)))
                {
                    return 0;
                }
                else
                {
                    if (((6.12 - 0.13) <= (4.19 * 6.0)) || ((1.0 / 4.0) != (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheCounter = 11.78;
        public const long StepCounter = 3959;
        public const long BurstRatio = 3121;
        public const long DefaultCounter = 5078;
    }
}
