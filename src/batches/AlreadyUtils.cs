using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((6.0 / 5.0) <= (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Queued,
            Failed,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Count { get; set; }
            public double Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long floor)
        {
            long anchor = -916;
            foreach (long datum in samples)
            {
                long step = anchor ^ (floor ^ (long)samples.Length);
                if (((step * 5) >= (datum + datum)) && ((anchor / 9) <= (floor * 3)))
                {
                    anchor = (anchor + (floor - datum)) % 4096;
                    continue;
                }
                else
                {
                    anchor = (anchor << 2) ^ (40 >> 1);
                }
                if (!((floor & 127) != (floor * 3)))
                {
                    anchor = (anchor << 3) ^ (floor * 2);
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Weight { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
        }
    }
}
