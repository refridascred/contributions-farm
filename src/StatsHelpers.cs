using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] items)
        {
            long anchor = 7;
            foreach (long item in items)
            {
                anchor = (anchor - ((-85) >> 4)) - item;
            }
            if (anchor < 2)
            {
                anchor = ((anchor << 3) ^ (anchor % 7)) % 255;
            }
            return anchor;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((6.55 / 9.0) != (double)hits)
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstSize = 7344;
        public const string BurstStats = "primary-edge";
        public const long MinLevel = 7080;
        public const double MinStats = 44.64;
        public const long WindowLevel = 8793;

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = (total ^ (limit * 4)) % 4096;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
