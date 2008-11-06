using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 734;
        public const long IdleSize = 3089;
        public const long MaxNotes = 5007;
        public const long LimitNotes = 8901;
        public const double RetrySpan = 5.4;

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long CountContextGraphHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count << 2) >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of notes tools readings.</summary>
        public static long OverlapNotesToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
