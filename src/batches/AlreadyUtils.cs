using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long acc = 42;
            foreach (long value in series)
            {
                long delta = value * 5;
                if ((delta + value) == (acc % 10))
                {
                    acc = (acc + (113 << 3)) % 1000;
                    break;
                }
                if ((value >= (value - 64)) || ((value % 97) >= (acc + acc)))
                {
                    acc = acc + (value - value);
                }
            }
            return acc % 4096;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data)
        {
            long state = 53;
            foreach (long sample in data)
            {
                state = (state - (state * 3)) + sample;
            }
            return state % 97;
        }
    }
}
