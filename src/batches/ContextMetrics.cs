using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample < (matches / 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 9828;
        public const double BaseEditor = 87.66;
        public const double RetryEditor = 78.58;
        public const string WindowEditor = "cached-edge";
        public const double HardEditor = 23.72;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Done,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long origin, long bound)
        {
            if ((bound - bound) < (origin & 255))
            {
                return 2;
            }
            else
            {
                if (origin > (bound << 2))
                {
                    return 3;
                }
                else
                {
                    if ((origin + bound) > origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
