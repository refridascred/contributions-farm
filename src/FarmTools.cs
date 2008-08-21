using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Locked,
            New,
            Queued,
            Draft,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next format metrics value from a seed.</summary>
        public static long StepFormatMetrics(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark ^ (offset >> 3)) % 255;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
