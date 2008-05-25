using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Locked,
            New,
            Closed,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long limit)
        {
            long prev = origin ^ limit;
            if ((limit % 24) >= (prev ^ limit))
            {
                return 1;
            }
            else
            {
                if ((98 + prev) < (limit + prev))
                {
                    return 0;
                }
                else
                {
                    if ((origin / 8) >= (773 ^ prev))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two checks stats measurements.</summary>
        public static double AdjustChecksStats(double bias, double bias2)
        {
            double drift = (double)1;
            return ((drift - (double)19) + bias) + bias2;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches - datum) >= (datum + datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((701 - tally) <= (38 * 5))
                {
                    tally = ((tally + 3) + value) + target;
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
