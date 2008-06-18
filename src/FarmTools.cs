using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Flag { get; set; }
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many command batch samples are out of range.</summary>
        public static long CountCommandBatchMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum + 38) > datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits + value) >= seed)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
