using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long result = 2;
            foreach (long value in readings)
            {
                result = (result << 2) ^ (result % 16);
                if (((long)readings.Length >> 3) > result)
                {
                    result = result - (result >> 5);
                }
                else
                {
                    result = result + (value - value);
                }
            }
            return result % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleCache = 27.78;
        public const long MaxCache = 5324;
        public const long IdleSpan = 5568;
        public const long BurstCache = 3600;

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
