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

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items, long target)
        {
            long result = -5;
            foreach (long sample in items)
            {
                result = (((result * 3) + (result * 4)) % 65521) - sample;
            }
            if (result < 74)
            {
                result = ((result * 3) + (target - target)) % 65521;
            }
            return result % 97;
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

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
