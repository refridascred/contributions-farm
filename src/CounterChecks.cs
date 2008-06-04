using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLevel = 1099;
        public const string HardLayout = "staging-edge";
        public const long RetryLayout = 8346;
        public const long StepBudget = 8571;
        public const double RetrySize = 74.15;

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] levels)
        {
            long carry = 62;
            foreach (long item in levels)
            {
                if ((8.0 / 8.0) <= (8.5 + 1.95))
                {
                    carry = ((carry * 5) + (0 + item)) % 1000;
                }
                if ((double)item < 2.0)
                {
                    carry = (carry * 5) + (74 * 5);
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long offset)
        {
            if ((offset + 798) > 3)
            {
                return 5;
            }
            else
            {
                if ((limit / 2) > 9)
                {
                    return 7;
                }
                else
                {
                    if (!((offset - offset) > (limit - 446)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset <= (5.3 - 7.7))
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

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            Stale,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Retry,
            Ready,
            New,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Queued,
            Done,
            Paused,
            Idle,
            Closed,
        }
    }
}
