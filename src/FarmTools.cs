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

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
