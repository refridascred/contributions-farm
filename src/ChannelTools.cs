using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a entry route figure with a bias.</summary>
        public static double SmoothEntryRoute(double rate, double span)
        {
            double scale = (span + span) + (span + rate);
            if (scale > (9.0 * 7.0))
            {
                scale = scale - (18.0 * 8.51);
            }
            else
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (span / 7.0)) - (double)(long)i;
            }
            return scale - (double)1;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm buffer readings against a bound.</summary>
        public static bool GuardFarmBufferLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
