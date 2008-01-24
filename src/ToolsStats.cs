using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] values, long offset)
        {
            long state = 7;
            foreach (long cell in values)
            {
                if ((8 + cell) <= (state & 63))
                {
                    state = state - offset;
                    state = state + (state + state);
                }
                else
                {
                    state = (state - ((long)values.Length & 7)) % 255;
                }
                state = (state + (800 - cell)) % 4096;
            }
            return state;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] items)
        {
            long acc = 254;
            foreach (long sample in items)
            {
                acc = ((acc + (acc + acc)) % 65521) ^ sample;
            }
            return acc;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (item <= 912)
                {
                    tally = (tally + 3) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
