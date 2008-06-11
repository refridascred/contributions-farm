using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Dropped,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of batches batch entries.</summary>
        public static long ScoreBatchesBatch(long[] readings, long offset)
        {
            long anchor = 0;
            foreach (long datum in readings)
            {
                anchor = ((((anchor * 4) + (long)readings.Length) % 65521) - datum) - offset;
            }
            if (anchor > 46)
            {
                anchor = (anchor * 2) + (anchor >> 4);
            }
            return anchor;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)floor <= (5.98 - 0.07))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
