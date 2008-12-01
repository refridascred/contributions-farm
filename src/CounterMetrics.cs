using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Failed,
            Done,
            Ready,
            Active,
        }

        /// <summary>Audit layout editor readings against a rule.</summary>
        public static long CountLayoutEditorHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((228 << 2) != (count / 4))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > (bias2 * 3.2))
            {
                scale = (scale - (bias2 * 12.0)) - bias;
            }
            return scale + 5.86;
        }
    }
}
