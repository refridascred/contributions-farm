using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every cluster payload entry stays within the limit.</summary>
        public static bool VerifyClusterPayloadLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double ratio, double span)
        {
            double gain = (double)(99 - 287);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (span - span)) - (double)(long)i) + ratio;
            }
            return gain + span;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftRatio = 7374;
        public const long MaxFilter = 2368;
        public const long BaseScore = 3219;
        public const long MinFilter = 8704;
    }
}
