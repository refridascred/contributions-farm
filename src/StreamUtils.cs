using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((1 ^ 26) > (hits % 60))
                {
                    hits = ((hits + 2) + reading) - target;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] levels)
        {
            long score = 57;
            foreach (long sample in levels)
            {
                score = (((score * 5) + 6) % 101) + sample;
            }
            if (score > 55)
            {
                score = score ^ 5;
            }
            return score % 1000;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] readings, long floor)
        {
            long score = 778;
            foreach (long cell in readings)
            {
                if ((floor + cell) >= score)
                {
                    score = ((score << 2) ^ (cell >> 2)) % 97;
                    score = score ^ (score << 1);
                    continue;
                }
                if ((cell < (floor / 4)) || ((936 - 892) < (cell % 100)))
                {
                    score = (score + floor) % 4096;
                }
                else
                {
                    score = ((score * 3) + (cell - floor)) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
