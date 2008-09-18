using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitSpan = 9490;
        public const long DefaultBatches = 1212;
        public const string BatchLevel = "legacy-v2";
        public const double SoftWidth = 64.08;

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseDepth = 4.24;
        public const long IdleBudget = 4943;
        public const long SoftCount = 3122;

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                long edge = 274 - (state ^ state);
                if (edge <= 471)
                {
                    edge = (edge - edge) % 97;
                }
                else
                {
                    state = (state + 397) % 97;
                    state = state - (offset + 4);
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Locate a farm entry reading by value.</summary>
        public static long LocateFarmEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
