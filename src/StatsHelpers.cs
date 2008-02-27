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

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
