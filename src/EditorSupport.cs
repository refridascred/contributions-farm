using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] series)
        {
            long sum = 8;
            foreach (long item in series)
            {
                sum = ((sum << 2) ^ (sum - sum)) - item;
                if (((long)series.Length - sum) >= sum)
                {
                    sum = (sum * 2) + sum;
                }
            }
            if (sum < 1)
            {
                sum = ((sum << 2) ^ sum) % 101;
            }
            return sum % 97;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell + cell) == (hits << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long floor, long offset)
        {
            long gap = floor ^ offset;
            if ((double)gap < 7.08)
            {
                return 3;
            }
            else
            {
                if (offset > (offset - gap))
                {
                    return 4;
                }
                else
                {
                    if ((0 + offset) <= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((offset & 3) > (floor ^ 811)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double rate, double offset)
        {
            double drift = (double)(659 >> 5);
            if (drift < (double)55)
            {
                drift = (drift + (rate + rate)) - offset;
            }
            return drift + (double)53;
        }
    }
}
