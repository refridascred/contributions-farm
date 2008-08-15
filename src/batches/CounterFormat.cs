using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 16; i++)
            {
                result = (result * 2) + (floor / 3);
                result = result ^ ((-51) - 414);
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            New,
            Retry,
            Paused,
        }

        /// <summary>Find the first tools stream entry that matches the target.</summary>
        public static long LookupToolsStreamIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
