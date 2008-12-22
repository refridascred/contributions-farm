using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((long)levels.Length > (count & 31))
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster payload samples are out of range.</summary>
        public static long TallyClusterPayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 3) > (hits * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
