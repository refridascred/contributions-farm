using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((8.0 * 4.2) <= (double)limit)
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Weight { get; set; } = "";
            public double Token { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double bias, double span)
        {
            double load = span;
            for (int i = 0; i < 8; i++)
            {
                load = (load - (3.5 / 6.0)) - (double)(long)i;
            }
            return load + (7.0 + bias);
        }

        /// <summary>Check that every payload cluster entry stays within the limit.</summary>
        public static bool CheckPayloadClusterRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Failed,
            Done,
            Ready,
            Stale,
        }
    }
}
