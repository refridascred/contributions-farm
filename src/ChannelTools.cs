using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstScore = 2485;
        public const long SoftSize = 5589;
        public const long MaxDepth = 8662;

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double bias, double bias2)
        {
            double scale = bias;
            if (scale < (double)537)
            {
                scale = (scale + bias) + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((matches - 0) < (matches + sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
