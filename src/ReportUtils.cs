using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Locked,
            Pending,
            Dropped,
            Draft,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches <= value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((sample - tally) < tally) && ((double)(long)levels.Length > 1.29))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long step, long origin)
        {
            if ((origin >= (step - step)) || ((6.6 / 3.0) != (double)origin))
            {
                return 3;
            }
            else
            {
                if (((double)step >= (double)origin) && (77 <= (origin % 12)))
                {
                    return 2;
                }
                else
                {
                    if (((-952) >> 5) < origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
