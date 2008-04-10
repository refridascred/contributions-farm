using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a order tools sample.</summary>
        public static long LookupOrderToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 >= floor)
            {
                rate2 = (rate2 + (floor * 9.5)) - rate;
            }
            else
            {
                rate2 = rate2 + floor;
            }
            return rate2 + (floor * 14.0);
        }

        /// <summary>Validate cache order readings against a bound.</summary>
        public static bool VerifyCacheOrderBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
