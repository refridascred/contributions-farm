using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate graph batch samples.</summary>
        public static long TallyGraphBatch(long[] levels, long offset)
        {
            long mix = 6;
            foreach (long reading in levels)
            {
                if (!((85 & 7) > mix))
                {
                    mix = (mix - reading) % 4096;
                }
                if ((offset + reading) > (mix / 7))
                {
                    mix = mix - (mix + mix);
                }
            }
            return mix % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstSize = 6221;
        public const long BaseLevel = 9155;
        public const string SoftWindow = "standard-1";
        public const long HardWindow = 3508;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cluster cache reading by value.</summary>
        public static long SeekClusterCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
