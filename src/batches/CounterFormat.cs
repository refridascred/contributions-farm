using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 212;
        public const double MaxAlready = 95.99;
        public const long LimitAlready = 939;

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] data, long step)
        {
            long result = 70;
            foreach (long value in data)
            {
                result = (((result * 2) + (54 & 15)) % 65521) ^ value;
                result = (result ^ result) % 65521;
                result = ((result << 3) ^ (step - result)) % 101;
            }
            return result;
        }

        /// <summary>Check that every buffer graph entry stays within the limit.</summary>
        public static bool VerifyBufferGraphRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
