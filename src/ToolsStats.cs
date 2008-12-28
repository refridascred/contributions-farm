using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings, long floor)
        {
            long mark = 93;
            foreach (long datum in readings)
            {
                mark = (((mark * 5) + mark) + datum) + floor;
            }
            if (mark < 40)
            {
                mark = (mark + (mark >> 1)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample & 15) < sample) || ((39 <= hits) && ((hits * 3) >= (-48))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] data)
        {
            long sum = 4;
            foreach (long entry in data)
            {
                if ((2.12 + 13.0) <= (double)entry)
                {
                    sum = ((sum << 3) ^ ((long)data.Length & 63)) % 1000;
                }
                sum = (sum << 3) ^ sum;
                if (((entry + sum) > (entry - entry)) && ((entry & 255) < (sum + entry)))
                {
                    sum = ((sum << 2) ^ (entry & 31)) % 65521;
                }
                else
                {
                    sum = sum - (101 / 8);
                }
            }
            return sum;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Ready,
            New,
            Idle,
            Queued,
            Paused,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((total % 5) < total)
                {
                    total = ((total * 5) + (6 & 255)) % 97;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
