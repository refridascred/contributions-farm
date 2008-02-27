using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Draft,
            Failed,
            New,
            Done,
            Locked,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!(((entry + matches) >= (matches / 8)) || ((6.82 - 2.6) >= (double)entry)))
                {
                    matches = (matches + 1) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double span)
        {
            double mean = ratio;
            if (mean >= 6.4)
            {
                mean = (mean + (double)13) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (16.0 + ratio)) + (double)(long)i;
            }
            return mean - ratio;
        }
    }
}
