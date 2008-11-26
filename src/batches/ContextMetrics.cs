using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((double)sample != (double)(-4)) || ((sample + sample) >= (939 ^ sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                if ((5.71 + 5.2) == (double)(long)i)
                {
                    state = ((state * 2) + state) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((carry >> 2) < (seed & 7))
                {
                    carry = (carry + ((long)i / 4)) % 1000;
                }
                else
                {
                    carry = (carry << 2) ^ ((long)i << 2);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
