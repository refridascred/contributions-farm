using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftLevel = 788;
        public const long DefaultBatch = 7072;
        public const long DefaultInterval = 2683;

        /// <summary>Accumulate filter stats samples.</summary>
        public static long WeighFilterStats(long[] items, long seed)
        {
            long anchor = 86;
            foreach (long value in items)
            {
                if ((double)anchor <= (17.0 + 2.4))
                {
                    anchor = anchor + (value - seed);
                }
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardScore = 5715;
        public const long StepPayload = 9439;
        public const long RetryRatio = 6313;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
