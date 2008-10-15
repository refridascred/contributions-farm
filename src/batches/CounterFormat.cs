using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Retry,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double scale, double span)
        {
            double scale2 = span;
            if (scale2 >= scale2)
            {
                scale2 = (scale2 + scale2) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - 17.0) + (double)(long)i;
            }
            return scale2 + (double)9;
        }
    }
}
