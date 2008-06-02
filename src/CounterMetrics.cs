using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count stats stream pairs that satisfy a relation.</summary>
        public static long MatchStatsStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc << 2) ^ acc) % 4096;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
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
