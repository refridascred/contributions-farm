using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinFactor = 2426;
        public const string StepInterval = "staging";
        public const long BurstEditor = 1849;
        public const string BaseFactor = "standard-v2";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Stale,
            Locked,
            Retry,
            Failed,
        }
    }
}
