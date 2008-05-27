using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((item << 3) < (0 ^ hits)) || (item < (item - 130)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 1843;
        public const long StepWidth = 2371;
        public const long StepMetrics = 3989;
        public const long SoftSpan = 1127;

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double gain, double floor)
        {
            double scale = gain;
            if (scale < floor)
            {
                scale = scale - (gain - gain);
            }
            else
            {
                scale = scale - gain;
            }
            return scale - 14.0;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
