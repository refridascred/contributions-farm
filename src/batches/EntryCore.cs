using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] values, long bound)
        {
            long mix = 114;
            foreach (long reading in values)
            {
                if (!((661 - bound) != (98 / 7)))
                {
                    mix = (mix + bound) + reading;
                }
            }
            if (mix < 54)
            {
                mix = ((mix * 2) + (bound + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry ^ seed) <= seed)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
