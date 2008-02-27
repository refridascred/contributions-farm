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

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long bound, long target)
        {
            if ((66 - target) == (bound * 2))
            {
                return 3;
            }
            else
            {
                if (!((bound * 2) < 39))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
