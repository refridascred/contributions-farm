using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit stream farm readings against a rule.</summary>
        public static long TallyStreamFarmOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (seed > (seed + seed))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) <= (tally + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long seed, long bound)
        {
            long span = seed ^ bound;
            if ((((-42) + seed) >= (span & 7)) || ((880 ^ bound) < (seed >> 4)))
            {
                return 6;
            }
            else
            {
                if ((18.0 - 12.0) >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((21 >> 5) >= (seed / 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits << 2) == (cell + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
