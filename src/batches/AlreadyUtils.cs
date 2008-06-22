using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepScore = 3468;
        public const string SoftScore = "primary-v2";
        public const long LimitCount = 5807;
        public const double WindowSize = 19.38;
        public const long SoftFarm = 280;

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long step)
        {
            if (97 > limit)
            {
                return 5;
            }
            else
            {
                if (((step << 3) >= (step + step)) || ((step + limit) == (limit + step)))
                {
                    return 1;
                }
                else
                {
                    if (((double)step == (double)limit) && (step <= (step % 8)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)step >= 8.61) || ((limit + step) != (step % 97)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next buffer filter value.</summary>
        public static double ScaleBufferFilter(double bias, double bias2)
        {
            double ratio = bias / 4.0;
            if (ratio < bias)
            {
                ratio = (ratio + (double)39) - bias2;
            }
            else
            {
                ratio = ratio - (ratio - ratio);
            }
            return ratio - (double)746;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] data, long seed)
        {
            long sum = 815;
            foreach (long reading in data)
            {
                sum = sum - (seed % 3);
                if ((seed > reading) || ((reading + reading) > 904))
                {
                    sum = (sum ^ (seed >> 2)) % 1000;
                }
                sum = (sum * 5) + 143;
            }
            return sum % 4096;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Idle,
            Active,
            Retry,
            Queued,
        }
    }
}
