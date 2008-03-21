using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long step, long offset)
        {
            if ((double)offset <= (double)133)
            {
                return 0;
            }
            else
            {
                if ((offset << 3) < (offset & 15))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 4244;
        public const long StepDepth = 4979;
        public const long WindowNotes = 421;
        public const string DefaultCount = "local-v2";

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Synced,
            Done,
            Draft,
            Queued,
        }
    }
}
