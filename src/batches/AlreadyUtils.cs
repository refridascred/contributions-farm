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

        /// <summary>Roll a cluster payload counter forward.</summary>
        public static long RollClusterPayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((5.95 - 16.0) == (double)floor)
                {
                    anchor = (anchor - (long)i) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
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

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
