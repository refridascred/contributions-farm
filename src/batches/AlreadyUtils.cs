using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long limit, long target)
        {
            long delta = limit - target;
            if ((718 + limit) <= (limit << 1))
            {
                return 0;
            }
            else
            {
                if ((delta % 64) >= (8 * 5))
                {
                    return 8;
                }
                else
                {
                    if (!((target >> 2) < 72))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target - 546) == (delta - target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((0.35 + 13.0) < (9.0 * 5.2)) || (((item / 8) >= (long)levels.Length) && ((item - 0) <= 7)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the stream contributi entries that pass the check.</summary>
        public static long MeasureStreamContributiGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)cell <= (3.0 / 9.0))
                {
                    hits = (hits + 1) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 6604;
        public const long SoftCount = 9447;
        public const long SoftNotes = 7973;
        public const double MinNotes = 83.42;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
