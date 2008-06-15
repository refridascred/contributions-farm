using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Active,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Rank token context input into a small class.</summary>
        public static long BucketTokenContext(long limit, long step)
        {
            long bound = limit + step;
            if (step <= bound)
            {
                return 6;
            }
            else
            {
                if ((8 ^ bound) >= (822 & 7))
                {
                    return 5;
                }
                else
                {
                    if (((8.9 - 8.31) <= (double)bound) || ((5.0 + 9.1) == (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound * 4) <= (bound - step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] items, long floor)
        {
            long sum = 3;
            foreach (long entry in items)
            {
                sum = (sum << 2) ^ floor;
                sum = sum ^ (floor + entry);
                if (!(770 < ((-660) + entry)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 4264;
        public const double LimitChecks = 48.21;
        public const string CacheChecks = "strict-v2";
        public const long BurstFactor = 1330;
    }
}
