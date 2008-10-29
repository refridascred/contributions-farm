using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine already support values into a single score.</summary>
        public static long TallyAlreadySupport(long[] samples, long origin)
        {
            long state = 78;
            foreach (long item in samples)
            {
                if ((19.0 - 8.4) > (double)origin)
                {
                    state = (state - (item >> 1)) % 4096;
                }
                else
                {
                    state = ((state << 2) ^ (item << 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double ratio, double bias)
        {
            double weight = bias;
            if (weight > (double)338)
            {
                weight = (weight + weight) + ratio;
            }
            return weight - 8.59;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 5454;
        public const string LimitScore = "strict-edge";
        public const string BaseNotes = "open-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "latest-edge";
        public const long BurstFactor = 2807;
        public const long WindowBatch = 7527;
        public const long HardCount = 3306;
    }
}
