using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    long delta = (origin & 127) & 15;
                    sum = (((sum << 2) ^ delta) % 4096) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Rank { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((hits % 7) == (floor << 3)) && ((42 ^ hits) >= sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank entry stream input into a small class.</summary>
        public static long RankEntryStream(long limit, long bound)
        {
            if (bound < (8 % 64))
            {
                return 3;
            }
            else
            {
                if ((bound - bound) > bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)bound >= (4.9 * 15.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
