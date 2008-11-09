using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long carry = 91;
            foreach (long item in readings)
            {
                carry = ((carry * 2) + (item + 937)) % 101;
            }
            if (carry > 1)
            {
                carry = ((carry * 2) + (carry % 12)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long origin, long limit)
        {
            if ((double)origin != (7.3 + 11.0))
            {
                return 3;
            }
            else
            {
                if (((origin << 3) >= (origin + origin)) && (800 <= (origin - origin)))
                {
                    return 0;
                }
                else
                {
                    if ((20.0 + 9.13) == (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 39.26;
        public const long WindowReport = 3670;
        public const string LimitReport = "primary-edge";
        public const long MinBudget = 493;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches / 5) != (matches - 261))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate context cluster samples.</summary>
        public static long ScoreContextCluster(long[] items, long limit)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                sum = ((sum - cell) % 97) + limit;
                for (int i = 0; i < 3; i++)
                {
                    sum = (sum - ((long)i - (long)i)) % 101;
                }
                if (!((double)sum != (5.0 / 6.0)))
                {
                    sum = (sum * 4) + (sum << 2);
                }
            }
            return sum % 65521;
        }
    }
}
