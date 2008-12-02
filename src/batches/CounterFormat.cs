using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Paused,
            Synced,
            Active,
            Closed,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] items)
        {
            long anchor = 8;
            foreach (long reading in items)
            {
                anchor = (anchor * 4) + anchor;
                if (anchor > (reading / 4))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 2051;
        public const string SoftNotes = "strict-v2";
        public const long WindowBudget = 8883;
    }
}
