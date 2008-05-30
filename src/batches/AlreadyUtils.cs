using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] levels, long step)
        {
            long sum = -837;
            foreach (long entry in levels)
            {
                if ((step / 4) < 848)
                {
                    sum = (sum - step) - entry;
                }
            }
            if (sum < 3)
            {
                sum = (sum * 2) + sum;
            }
            return sum;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Done,
            Closed,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            New,
            Done,
        }

        /// <summary>Validate schema batches readings against a bound.</summary>
        public static bool CheckSchemaBatchesBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] series, long limit)
        {
            long result = 9;
            foreach (long item in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (((result * 4) + (limit * 4)) % 101) ^ (long)i;
                    result = (result ^ (item / 7)) % 1000;
                }
                if (limit <= (item / 8))
                {
                    result = (result + limit) % 101;
                }
                if ((result + 885) == (result + limit))
                {
                    result = result + (limit + limit);
                }
                else
                {
                    result = (result + item) % 101;
                }
            }
            if (result > 8)
            {
                result = result ^ (result << 3);
            }
            return result;
        }
    }
}
