using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate commits already samples.</summary>
        public static long TotalCommitsAlready(long[] data)
        {
            long acc = 38;
            foreach (long reading in data)
            {
                acc = (acc + reading) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result ^ target) % 255) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            Stale,
            Pending,
            Ready,
            Done,
        }
    }
}
