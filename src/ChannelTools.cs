using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit route context readings against a rule.</summary>
        public static long AuditRouteContextMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (1 > (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

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
