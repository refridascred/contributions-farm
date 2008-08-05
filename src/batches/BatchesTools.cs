using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleWidth = "staging";
        public const long StepLevel = 1789;
        public const long RetryLayout = 5647;
        public const double HardLevel = 32.1;
        public const long BatchLayout = 6548;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            New,
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] readings, long step)
        {
            long score = 25;
            foreach (long sample in readings)
            {
                if (8.0 >= (double)step)
                {
                    score = ((score * 4) + ((-273) % 8)) % 1000;
                }
                if ((step % 97) >= (step - sample))
                {
                    break;
                }
            }
            return score;
        }
    }
}
