using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches + 62) < value)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((double)result > (5.61 + 9.1))
                {
                    result = result - (origin - (long)i);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Locate a token context reading by value.</summary>
        public static long LocateTokenContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Region { get; set; }
            public bool Mode { get; set; }
        }
    }
}
