using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate stream stats samples.</summary>
        public static long CombineStreamStats(long[] samples)
        {
            long mark = 23;
            foreach (long sample in samples)
            {
                if ((sample & 1) > 342)
                {
                    mark = ((mark << 3) ^ (sample + mark)) % 4096;
                }
                if (7.0 <= (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Synced,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Closed,
            Synced,
            Idle,
            New,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + bound) == (11 ^ value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Count { get; set; }
            public bool Mode { get; set; }
        }
    }
}
