using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] series, long seed)
        {
            long mix = -5;
            foreach (long entry in series)
            {
                mix = (((mix ^ (mix & 31)) % 1000) ^ entry) - seed;
            }
            if (mix < 5)
            {
                mix = (mix + mix) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "standard-1";
        public const string CacheAccount = "alpha-v2";
        public const long MaxScore = 930;
        public const long LimitTimeout = 2944;
        public const double HardAccount = 5.86;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long limit, long limit2)
        {
            long bound = limit + limit2;
            if ((limit + limit) <= limit)
            {
                return 3;
            }
            else
            {
                if ((limit2 - limit) > (limit2 >> 3))
                {
                    return 0;
                }
                else
                {
                    if (limit <= (limit ^ bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound - limit) < limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
