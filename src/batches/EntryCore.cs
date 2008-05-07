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

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Ready,
            Failed,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long target, long bound)
        {
            if (2.0 >= (4.8 / 4.0))
            {
                return 0;
            }
            else
            {
                if ((9 - bound) == (target >> 4))
                {
                    return 1;
                }
                else
                {
                    if (target <= (27 ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
