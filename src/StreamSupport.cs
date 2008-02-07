using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double ratio, double span)
        {
            double rate = (double)(770 / 2);
            if (rate < (double)22)
            {
                rate = (rate - ratio) - span;
            }
            return rate - ratio;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a buffer tools counter forward.</summary>
        public static long DeriveBufferTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                result = ((result << 3) ^ result) % 1000;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
