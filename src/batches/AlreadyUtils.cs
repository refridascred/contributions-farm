using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] data, long seed)
        {
            long anchor = 745;
            foreach (long reading in data)
            {
                long lane = (reading << 3) & 1;
                if ((double)lane > (3.0 - 3.0))
                {
                    anchor = ((anchor * 4) + (reading - reading)) - seed;
                    break;
                }
                if ((anchor + anchor) > (reading - reading))
                {
                    anchor = (anchor + reading) % 255;
                }
                else
                {
                    anchor = anchor - (987 * 4);
                }
            }
            return anchor;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc * 2) + target;
                acc = (acc << 3) ^ (acc ^ acc);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count farm editor pairs that satisfy a relation.</summary>
        public static long PairFarmEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((seed - seed) > cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
