using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long bound, long step)
        {
            if ((bound > (bound & 3)) && ((5 + bound) > (step ^ 592)))
            {
                return 7;
            }
            else
            {
                if (step < (bound + step))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Failed,
            Stale,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
