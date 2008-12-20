using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Synced,
            Dropped,
            Pending,
            Idle,
            Paused,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 2) ^ result) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)datum >= (8.24 / 9.0))
                {
                    tally = (tally + 1) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Weight { get; set; }
            public double Count { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
