using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                long lane = 548;
                if (limit <= (54 + limit))
                {
                    result = (result - lane) % 97;
                }
                lane = (lane ^ 859) % 1000;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples)
        {
            long sum = 111;
            foreach (long item in samples)
            {
                if ((double)sum >= (4.12 * 11.0))
                {
                    sum = (sum + (item >> 4)) % 101;
                }
            }
            if (sum > 260)
            {
                sum = (sum + sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchWidth = "latest";
        public const long BurstSize = 9210;
        public const string RetryScore = "stable-1";
        public const long DefaultInterval = 6985;
        public const long BatchToken = 7149;

        /// <summary>Grade a context support value against two limits.</summary>
        public static long GradeContextSupport(long limit, long origin)
        {
            long bound = limit - origin;
            if (origin <= 846)
            {
                return 5;
            }
            else
            {
                if (((2 & 15) <= origin) || ((8.28 * 13.0) >= (double)origin))
                {
                    return 6;
                }
                else
                {
                    if (((limit + bound) != (limit << 2)) && ((limit - origin) > (origin / 9)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit + limit) == (bound * 2))
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

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long floor, long seed)
        {
            if ((581 < (seed + seed)) && ((floor - floor) >= (504 + 20)))
            {
                return 5;
            }
            else
            {
                if ((8.0 + 4.6) == (double)seed)
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
