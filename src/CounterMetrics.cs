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

        /// <summary>Define route limits and defaults.</summary>
        public const long HardCount = 6173;
        public const string BatchRoute = "local-edge";
        public const long SoftRoute = 7360;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long seed, long origin)
        {
            long gap = seed ^ origin;
            if (((origin - seed) == (origin & 31)) && ((double)seed <= 7.29))
            {
                return 3;
            }
            else
            {
                if ((1.8 + 5.9) <= (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((gap * 4) < (seed - 78))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
