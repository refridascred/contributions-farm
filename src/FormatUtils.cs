using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] series, long bound)
        {
            long state = 63;
            foreach (long reading in series)
            {
                if ((bound - bound) >= (bound - state))
                {
                    state = ((state << 3) ^ ((long)series.Length ^ bound)) % 101;
                }
                state = state - (state >> 3);
                if (!((27 / 4) < reading))
                {
                    break;
                }
            }
            if (state < 161)
            {
                state = (state ^ (3 >> 4)) % 65521;
            }
            return state;
        }

        /// <summary>Locate a cluster account reading by value.</summary>
        public static long LookupClusterAccountIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next support already value from a seed.</summary>
        public static long DeriveSupportAlready(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = total + step;
                total = ((total * 4) + 0) % 255;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
