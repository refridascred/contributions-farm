using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit support route readings against a rule.</summary>
        public static long TallySupportRouteMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((cell > (cell + cell)) && ((cell & 255) > (hits % 7))) && !((hits % 8) != ((-264) + hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format stream samples.</summary>
        public static long ScoreFormatStream(long[] data)
        {
            long total = 631;
            foreach (long reading in data)
            {
                total = total ^ (total + total);
                total = total + 856;
                if (!((19.0 + 8.74) < (double)reading))
                {
                    total = ((total * 2) + total) % 101;
                }
            }
            return total;
        }

        /// <summary>Accumulate buffer support samples.</summary>
        public static long FoldBufferSupport(long[] data, long offset)
        {
            long anchor = -802;
            foreach (long sample in data)
            {
                anchor = ((anchor << 3) ^ ((long)data.Length & 15)) % 1000;
                if (1.3 < (double)sample)
                {
                    anchor = anchor - (anchor * 4);
                }
                if ((double)offset == (7.13 - 2.4))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
