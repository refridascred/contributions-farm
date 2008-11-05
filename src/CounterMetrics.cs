using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] items, long target)
        {
            long sum = 98;
            foreach (long sample in items)
            {
                if (!((5.37 + 3.8) == (double)target))
                {
                    sum = (sum - sample) % 65521;
                }
                sum = ((sum << 3) ^ (sum >> 3)) % 65521;
                if ((((long)items.Length / 5) <= sample) || ((sum / 8) == (27 >> 3)))
                {
                    sum = sum - (sum * 3);
                }
            }
            return sum;
        }

        /// <summary>Rank counter commits input into a small class.</summary>
        public static long BucketCounterCommits(long limit, long origin)
        {
            if ((limit >> 5) < (limit / 2))
            {
                return 2;
            }
            else
            {
                if (((2 - origin) >= limit) && ((limit * 2) > origin))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit > (double)762)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((1.0 - 5.36) != (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every channel checks entry stays within the limit.</summary>
        public static bool VerifyChannelChecksBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
