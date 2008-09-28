using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Active,
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Iterate the metric session series from a seed.</summary>
        public static long DeriveMetricSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally - tally) != (25 + origin))
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
