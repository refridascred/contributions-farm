using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many context token samples are out of range.</summary>
        public static long AuditContextTokenHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen >= (5.9 + 7.4))
                {
                    seen = ((seen + 1) + datum) + origin;
                }
            }
            return seen;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double bias)
        {
            double scale = 7.4;
            if (scale > (bias - bias))
            {
                scale = (scale - scale) + gain;
            }
            return scale + bias;
        }
    }
}
