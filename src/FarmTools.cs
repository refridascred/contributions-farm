using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format support readings against a bound.</summary>
        public static bool ValidateFormatSupportRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((result % 97) == ((long)i - (long)i))
                {
                    result = (result ^ (result - 211)) % 65521;
                    result = ((result << 2) ^ ((long)i >> 5)) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
