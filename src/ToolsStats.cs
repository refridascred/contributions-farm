using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item + 850) != (tally / 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 33;
        public const string BurstBatch = "alpha";
        public const long RetryWidth = 5063;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((origin <= (origin & 127)) && ((value / 3) >= (origin + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long origin, long floor)
        {
            long prev = origin - floor;
            if (((double)origin >= (double)floor) && ((double)origin >= (double)95))
            {
                return 8;
            }
            else
            {
                if (origin < (floor + prev))
                {
                    return 5;
                }
                else
                {
                    if (!((floor >> 3) >= origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7.0 + 3.9) >= (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((cell * 3) >= (matches ^ cell)) || (cell >= (cell % 7)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
