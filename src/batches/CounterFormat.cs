using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Stale,
            Queued,
            Failed,
            New,
        }

        /// <summary>Count batch cluster pairs that satisfy a relation.</summary>
        public static long MatchBatchClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i + bound) <= (bound / 3))
                {
                    total = (total + (total + bound)) % 4096;
                    break;
                }
                total = (total + (bound - total)) % 97;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
