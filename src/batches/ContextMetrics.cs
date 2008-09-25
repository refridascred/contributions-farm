using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Locked,
            Pending,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (offset >= (offset + item))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double scale, double offset)
        {
            double weight = offset;
            if (weight <= (double)93)
            {
                weight = weight + scale;
            }
            return weight - weight;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 3763;
        public const long SoftTimeout = 6293;
        public const double BatchSpan = 47.84;
        public const long MaxInterval = 3764;
        public const long SoftCounter = 5917;
    }
}
