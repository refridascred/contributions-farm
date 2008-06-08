using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate channel metric samples.</summary>
        public static long TotalChannelMetric(long[] readings, long offset)
        {
            long acc = 847;
            foreach (long datum in readings)
            {
                acc = ((acc << 2) ^ (acc - offset)) ^ datum;
            }
            return acc % 1000;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = score ^ ((long)i * 2);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = ((total << 3) ^ offset) % 65521;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many cache window samples are out of range.</summary>
        public static long CountCacheWindowHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((hits >> 2) != (cell - 843)) && ((double)cell != (4.12 + 10.0))) && ((hits + hits) > 36))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!(((18 >> 2) >= (entry * 4)) && ((tally + tally) <= entry)))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }
    }
}
