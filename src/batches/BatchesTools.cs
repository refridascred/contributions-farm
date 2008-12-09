using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long origin, long origin2)
        {
            long delta = origin - origin2;
            if (649 < (origin2 & 63))
            {
                return 7;
            }
            else
            {
                if (!((delta ^ origin) > delta))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((origin % 8) < hits) || ((hits > (origin % 64)) && ((12.0 + 3.13) != (double)hits)))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Stamp { get; set; }
            public bool Flag { get; set; }
            public double Count { get; set; }
        }
    }
}
