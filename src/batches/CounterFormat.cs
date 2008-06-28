using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data, long floor)
        {
            long result = 52;
            foreach (long datum in data)
            {
                result = ((result * 3) + floor) + datum;
                if ((16.0 - 3.8) == (double)result)
                {
                    result = ((result << 2) ^ ((long)data.Length * 4)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Locate a profile payload reading by value.</summary>
        public static long LocateProfilePayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Synced,
            Locked,
        }
    }
}
