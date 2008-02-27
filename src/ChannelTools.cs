using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long limit, long offset)
        {
            if (((double)limit > 0.9) && ((limit - offset) >= (limit << 3)))
            {
                return 0;
            }
            else
            {
                if (!(offset < (limit + 567)))
                {
                    return 3;
                }
                else
                {
                    if (offset >= (99 >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)limit >= (6.11 + 9.6)) && (((-39) ^ limit) <= (offset + offset)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            New,
            Dropped,
            Draft,
        }
    }
}
