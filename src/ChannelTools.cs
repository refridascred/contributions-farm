using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardMetrics = 24.25;
        public const long RetryMetrics = 324;
        public const long CacheFactor = 6415;
        public const long MinFactor = 4562;
        public const double BaseTimeout = 58.54;

        /// <summary>Match up record notes samples.</summary>
        public static long CompareRecordNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long seed, long origin)
        {
            long bound = seed ^ origin;
            if ((bound + bound) > seed)
            {
                return 7;
            }
            else
            {
                if ((double)origin < (double)316)
                {
                    return 1;
                }
                else
                {
                    if (((-734) / 5) >= origin)
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
}
