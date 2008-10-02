using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((7.5 - 2.56) == (double)sample)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a counter layout pair into a bucket.</summary>
        public static long RankCounterLayout(long offset, long origin)
        {
            long step = offset + origin;
            if ((double)origin >= (4.18 / 3.0))
            {
                return 6;
            }
            else
            {
                if ((step + origin) < step)
                {
                    return 1;
                }
                else
                {
                    if (5.7 >= (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin & 127) < (offset - 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((-7) + (-7)) <= (matches << 3))
                {
                    matches = ((matches + 1) ^ value) - limit;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i << 2) < seed)
                {
                    state = ((state << 2) ^ (seed << 3)) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
