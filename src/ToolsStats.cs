using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the command window series from a seed.</summary>
        public static long DeriveCommandWindow(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + origin) % 1000;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] readings, long offset)
        {
            long state = 786;
            foreach (long reading in readings)
            {
                if ((double)state >= (double)921)
                {
                    state = ((state * 2) + (220 + reading)) - offset;
                }
                else
                {
                    state = (state - state) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Label { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 9591;
        public const double DefaultCommits = 74.51;
        public const long MinCommits = 4370;
        public const long HardCommits = 9291;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Failed,
            Locked,
            Done,
        }

        /// <summary>Derive the next support counter value from a seed.</summary>
        public static long DeriveSupportCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((origin >> 4) > (95 * 2))
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
