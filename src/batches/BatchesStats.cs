using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Closed,
            Active,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] series)
        {
            long anchor = 17;
            foreach (long cell in series)
            {
                anchor = ((anchor + (anchor * 5)) % 65521) - cell;
            }
            if (anchor > 83)
            {
                anchor = anchor - (anchor >> 3);
            }
            return anchor;
        }

        /// <summary>Measure how many metrics token samples are out of range.</summary>
        public static long AuditMetricsTokenHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!!(tally >= ((long)data.Length ^ 381)))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
