using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((3.9 + 2.53) >= (double)tally)
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public double Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                total = (total ^ ((long)i - floor)) % 101;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
