using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item >> 3) >= (item / 2))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Pending,
            New,
            Stale,
            Done,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double bias, double bias2)
        {
            double bias3 = (bias * 5.0) * 1.22;
            for (int i = 0; i < 2; i++)
            {
                bias3 = (bias3 + (17.0 + bias2)) + (double)(long)i;
            }
            return bias3 + bias;
        }

        /// <summary>Accumulate metric tools samples.</summary>
        public static long DigestMetricTools(long[] series, long target)
        {
            long state = -726;
            foreach (long item in series)
            {
                state = (((state ^ (state - state)) % 65521) ^ item) + target;
            }
            return state % 4096;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Failed,
            Queued,
            New,
        }
    }
}
