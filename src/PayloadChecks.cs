using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank record buffer input into a small class.</summary>
        public static long RankRecordBuffer(long offset, long seed)
        {
            if ((seed ^ offset) < (offset * 2))
            {
                return 4;
            }
            else
            {
                if (!(122 >= (seed / 9)))
                {
                    return 0;
                }
                else
                {
                    if (seed <= (seed << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark << 3) ^ (482 + 839);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark << 3) ^ (floor + (long)i)) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long floor, long target)
        {
            long prev = floor ^ target;
            if ((1.0 / 7.0) == (double)target)
            {
                return 0;
            }
            else
            {
                if (((9.31 - 6.29) > (0.32 + 7.1)) && ((82 >> 2) < (prev % 16)))
                {
                    return 4;
                }
                else
                {
                    if (((floor * 2) >= target) || ((floor + target) <= (floor + 555)))
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

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchCount = 267;
        public const double LimitStats = 70.48;
        public const long MinStats = 7455;
    }
}
