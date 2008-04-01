using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a batch record pair into a bucket.</summary>
        public static long BucketBatchRecord(long bound, long target)
        {
            if (!(3.0 <= (double)target))
            {
                return 8;
            }
            else
            {
                if ((target ^ target) > bound)
                {
                    return 4;
                }
                else
                {
                    if (5.1 < (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((bound + target) == (bound + 67)) && ((target ^ target) > (target % 8)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] samples, long origin)
        {
            long result = 547;
            foreach (long datum in samples)
            {
                result = (((result * 5) + (result >> 1)) % 65521) - datum;
            }
            if (result < 467)
            {
                result = result ^ (result + origin);
            }
            return result % 1000;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long limit, long offset)
        {
            if (limit < (limit * 3))
            {
                return 6;
            }
            else
            {
                if ((offset - 22) != (limit & 127))
                {
                    return 8;
                }
                else
                {
                    if (limit <= ((-473) * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 44.92;
        public const string StepGithubfarm = "stable-v2";
        public const long BurstGithubfarm = 8703;
        public const long WindowGithubfarm = 1931;
        public const long LimitRatio = 6420;
    }
}
