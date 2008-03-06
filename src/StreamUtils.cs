using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Locate a cluster layout reading by value.</summary>
        public static long LocateClusterLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell <= (0 & 7))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the account metrics entries that pass the check.</summary>
        public static long TallyAccountMetricsHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((target % 10) < seen))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!(((bound ^ bound) == (489 - 6)) || ((bound ^ bound) <= (327 - (-743)))))
                {
                    score = score + (bound & 127);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
