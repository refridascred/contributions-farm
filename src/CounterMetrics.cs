using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two metric payload measurements.</summary>
        public static double AdjustMetricPayload(double gain, double bias)
        {
            double scale = 6.3 - gain;
            if (scale < 6.7)
            {
                scale = scale + bias;
            }
            return scale - (gain / 8.0);
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((floor - seen) < datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Synced,
            New,
            Locked,
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
