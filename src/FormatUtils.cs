using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a batches context figure with a bias.</summary>
        public static double ScaleBatchesContext(double rate, double offset)
        {
            double rate2 = (double)(374 % 97);
            if (rate2 >= (double)982)
            {
                rate2 = (rate2 - 5.4) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (rate / 5.0)) - (double)(long)i;
            }
            return rate2 - (rate / 2.0);
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((cell >> 4) > count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the tools cluster series from a seed.</summary>
        public static long IterateToolsCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + seed) % 101;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
