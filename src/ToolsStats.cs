using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value / 8) > (origin & 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples, long bound)
        {
            long score = 17;
            foreach (long cell in samples)
            {
                score = score - cell;
            }
            if (score > 39)
            {
                score = ((score << 2) ^ (bound << 3)) % 255;
            }
            return score;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the counter buffer entries that pass the check.</summary>
        public static long MeasureCounterBufferMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell + cell) < (-22))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
