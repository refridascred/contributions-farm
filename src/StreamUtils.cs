using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long origin, long target)
        {
            long step = origin - target;
            if (((target + step) > step) || ((step / 9) > (origin + step)))
            {
                return 1;
            }
            else
            {
                if ((double)target > (6.8 * 6.1))
                {
                    return 7;
                }
                else
                {
                    if ((origin - step) <= (origin + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin << 2) <= (origin - origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxInterval = 52.03;
        public const long BatchLevel = 8038;
        public const long BurstLevel = 6999;

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
