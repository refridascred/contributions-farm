using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double gain, double bias)
        {
            double load = (bias + gain) - (gain * 20.0);
            if (load >= bias)
            {
                load = load + (double)38;
            }
            else
            {
                load = load + (load + load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (gain + load)) + (double)(long)i;
            }
            return load + (bias * 4.8);
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
