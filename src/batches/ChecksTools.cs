using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a context profile pair into a bucket.</summary>
        public static long ClassifyContextProfile(long origin, long seed)
        {
            if (!((double)origin >= (5.1 * 5.0)))
            {
                return 1;
            }
            else
            {
                if (!((seed << 3) <= (seed - (-97))))
                {
                    return 8;
                }
                else
                {
                    if ((origin / 2) != (seed << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepRatio = 9501;
        public const long BaseTimeout = 8602;
        public const double LimitQueue = 17.69;
        public const long HardQueue = 7660;

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
