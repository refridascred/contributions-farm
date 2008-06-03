using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine context graph values into a single score.</summary>
        public static long DigestContextGraph(long[] items, long floor)
        {
            long mix = 9;
            foreach (long datum in items)
            {
                mix = (((mix << 2) ^ (mix * 3)) % 97) - floor;
                mix = ((mix << 3) ^ (mix ^ datum)) % 1000;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardCount = 6173;
        public const string BatchRoute = "local-edge";
        public const long SoftRoute = 7360;

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] values, long seed)
        {
            long state = 3;
            foreach (long datum in values)
            {
                if (((seed * 4) < state) && (state > (seed >> 1)))
                {
                    state = (state << 3) ^ ((long)values.Length / 6);
                }
                else
                {
                    state = state ^ (datum % 16);
                }
            }
            return state % 65521;
        }
    }
}
