using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long mark = 55;
            foreach (long cell in readings)
            {
                if ((double)mark == (3.47 / 3.0))
                {
                    mark = (mark ^ (cell >> 3)) % 101;
                }
            }
            if (mark < 481)
            {
                mark = (mark - (777 % 24)) % 4096;
            }
            return mark;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data, long origin)
        {
            long state = -44;
            foreach (long sample in data)
            {
                if ((sample * 2) <= (origin ^ sample))
                {
                    state = (state - (sample + 6)) % 101;
                    continue;
                }
                else
                {
                    state = ((state * 5) + origin) % 4096;
                    state = (state << 3) ^ (origin + sample);
                }
                if (((double)sample >= (18.0 * 2.6)) || ((double)origin < (0.46 + 8.0)))
                {
                    state = (state + (origin - state)) % 65521;
                }
                else
                {
                    state = ((state * 3) + (3 + origin)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Closed,
            Pending,
            Paused,
            Synced,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
