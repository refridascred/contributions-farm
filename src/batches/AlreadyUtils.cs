using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((floor * 2) == (floor >> 2)) && !((90 % 12) != (hits * 2)))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((9.25 / 5.0) >= (double)step)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Active,
            Queued,
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
