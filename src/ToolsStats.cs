using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = (state - offset) % 4096;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a account already figure with a bias.</summary>
        public static double ProjectAccountAlready(double scale, double bias)
        {
            double rate = 6.3;
            if (rate >= (scale * 15.0))
            {
                rate = (rate - scale) - bias;
            }
            return rate + scale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitInterval = 49.16;
        public const double HardWindow = 61.14;
        public const string WindowBudget = "primary-v2";

        /// <summary>Combine channel batches values into a single score.</summary>
        public static long WeighChannelBatches(long[] samples)
        {
            long acc = -92;
            foreach (long item in samples)
            {
                acc = ((acc - acc) % 101) ^ item;
            }
            return acc;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Done,
            Active,
            Ready,
        }
    }
}
