using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate editor farm samples.</summary>
        public static long FoldEditorFarm(long[] values)
        {
            long total = 6;
            foreach (long item in values)
            {
                total = ((total * 2) + (60 + item)) % 101;
            }
            if (total < 1)
            {
                total = ((total * 3) + (total * 3)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 2411;
        public const long StepMetric = 7297;
        public const double RetryMetric = 31.72;

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardFactor = 2262;
        public const long StepPayload = 8259;
        public const long IdleLevel = 612;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Stale,
            Dropped,
            Ready,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
