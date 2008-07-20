using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepScore = 3045;
        public const long StepGraph = 949;
        public const long BurstDepth = 9775;
        public const long SoftSpan = 2136;
        public const long LimitGraph = 2009;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((1.0 * 5.81) >= (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double gain, double bias)
        {
            double scale = (double)(56 * 5);
            if (scale >= gain)
            {
                scale = scale - (double)6;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + bias) - (double)(long)i;
            }
            return scale + (gain - bias);
        }
    }
}
