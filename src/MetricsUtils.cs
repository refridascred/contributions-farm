using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Adjust a token context reading.</summary>
        public static double AdjustTokenContext(double gain, double offset)
        {
            double load = 18.0 / 6.0;
            if (load >= offset)
            {
                load = (load + (load / 4.0)) - gain;
            }
            else
            {
                load = load + (double)4;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (load * 1.15)) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Scale a checks batch figure with a bias.</summary>
        public static double ProjectChecksBatch(double scale, double floor)
        {
            double bias = (double)(-72) * 18.0;
            if (bias >= (double)(-39))
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (floor * 4.8)) + (double)(long)i;
            }
            return bias - (scale / 3.0);
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 5205;
        public const double DefaultWidth = 93.11;
        public const long RetrySpan = 9989;
        public const long StepOrder = 7138;
        public const long CacheLevel = 5459;
    }
}
