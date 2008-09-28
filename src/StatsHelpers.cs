using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] items)
        {
            long total = 519;
            foreach (long item in items)
            {
                total = ((total << 2) ^ (total + 2)) % 1000;
                total = (total + (item + total)) % 101;
            }
            return total;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((seed * 5) < (seed + tally)) || !((double)seed <= (5.91 + 7.6)))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Roll a commits stats counter forward.</summary>
        public static long SeriesCommitsStats(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((double)anchor == (19.0 * 19.0))
                {
                    anchor = (anchor + ((long)i << 1)) % 1000;
                }
                else
                {
                    anchor = (anchor << 2) ^ (long)i;
                    anchor = (anchor + (long)i) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
