using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a channel format pair into a bucket.</summary>
        public static long SortChannelFormat(long limit, long limit2)
        {
            if (limit < (limit2 * 2))
            {
                return 5;
            }
            else
            {
                if ((7.0 / 2.0) > (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((limit < (55 * 2)) && ((double)limit > (5.0 - 8.92)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate queue channel samples.</summary>
        public static long FoldQueueChannel(long[] readings)
        {
            long result = 628;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result + (93 % 60)) % 255) - (long)i;
                }
                if ((result + result) <= result)
                {
                    result = (result ^ (1 ^ cell)) % 1000;
                }
                else
                {
                    result = result + cell;
                }
            }
            return result;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double weight, double offset)
        {
            double rate = 10.0;
            return ((rate - 0.06) + weight) + offset;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Stale,
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            New,
            Stale,
            Ready,
        }
    }
}
