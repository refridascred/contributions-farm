using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Active,
            Retry,
            Synced,
        }

        /// <summary>Fold a list of notes support readings.</summary>
        public static long ScoreNotesSupport(long[] items, long floor)
        {
            long mix = 76;
            foreach (long reading in items)
            {
                if (((reading + floor) <= (floor >> 5)) || ((reading * 5) != (reading ^ mix)))
                {
                    mix = (mix * 2) + floor;
                }
            }
            return mix % 97;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (95 >= (hits - hits))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Region { get; set; } = "";
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
