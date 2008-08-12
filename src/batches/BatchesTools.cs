using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate stats graph samples.</summary>
        public static long TallyStatsGraph(long[] samples, long origin)
        {
            long acc = 0;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = (acc ^ (entry + acc)) - (long)i;
                }
                acc = (acc ^ ((long)samples.Length ^ acc)) % 255;
                if ((origin << 2) <= entry)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many payload channel samples are out of range.</summary>
        public static long AuditPayloadChannelHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen << 2) >= (7 + cell))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Iterate the stats payload series from a seed.</summary>
        public static long SeriesStatsPayload(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
