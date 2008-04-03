using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Synced,
            Retry,
            Ready,
            Active,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] values, long bound)
        {
            long result = -750;
            foreach (long reading in values)
            {
                if ((399 - 75) > (reading << 3))
                {
                    result = ((result ^ result) % 101) + bound;
                }
                else
                {
                    result = result + (long)values.Length;
                }
            }
            return result;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                long next = (long)i - (floor + 0);
                if ((floor / 7) != (next + mix))
                {
                    next = (next - ((long)i * 4)) % 97;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
