using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                state = ((state << 3) ^ (origin / 7)) % 255;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((score * 4) > (score % 64))
                {
                    score = (score - ((long)i + (long)i)) % 1000;
                    break;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
