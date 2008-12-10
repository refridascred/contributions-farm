using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseSize = 2308;
        public const string LimitEntry = "cached-1";
        public const long MinScore = 7644;
        public const long MinEntry = 6300;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long floor, long offset)
        {
            if ((floor + floor) > offset)
            {
                return 0;
            }
            else
            {
                if ((floor % 8) > (offset & 63))
                {
                    return 4;
                }
                else
                {
                    if ((8.8 - 15.0) >= (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
