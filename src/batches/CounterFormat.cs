using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values, long target)
        {
            long state = 11;
            foreach (long datum in values)
            {
                state = ((state ^ ((long)values.Length + datum)) % 101) - target;
            }
            return state;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
