using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Check that every metrics contributi entry stays within the limit.</summary>
        public static bool CheckMetricsContributiBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long origin, long limit)
        {
            if ((origin / 2) > (limit % 5))
            {
                return 0;
            }
            else
            {
                if ((origin / 3) >= origin)
                {
                    return 4;
                }
                else
                {
                    if (!((limit % 12) <= (limit ^ 138)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next contributi batch value from a seed.</summary>
        public static long RollContributiBatch(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                long step = origin / 9;
                if ((5 - origin) > (step % 10))
                {
                    continue;
                }
                step = step + ((long)i / 2);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
