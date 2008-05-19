using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many batch channel samples are out of range.</summary>
        public static long MeasureBatchChannelHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((1.6 - 8.06) == (double)step)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session contributi samples are out of range.</summary>
        public static long CountSessionContributiMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item < (seed + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] readings)
        {
            long state = 8;
            foreach (long sample in readings)
            {
                state = state ^ (53 + state);
                for (int i = 0; i < 2; i++)
                {
                    state = ((state * 4) + (248 * 2)) - (long)i;
                    state = state ^ (sample + sample);
                }
                if ((double)state <= (4.15 * 4.0))
                {
                    state = ((state << 2) ^ (sample & 31)) % 65521;
                }
                else
                {
                    state = state + (state % 7);
                }
                if ((double)(long)readings.Length <= (12.0 / 6.0))
                {
                    break;
                }
            }
            if (state > 44)
            {
                state = (state ^ (state - state)) % 97;
            }
            return state % 97;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
