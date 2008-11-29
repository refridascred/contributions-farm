using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            New,
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((sample * 5) <= origin))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the schema support series from a seed.</summary>
        public static long RollSchemaSupport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank metrics githubfarm input into a small class.</summary>
        public static long SortMetricsGithubfarm(long seed, long seed2)
        {
            long bound = seed ^ seed2;
            if ((seed2 + 7) == (seed * 3))
            {
                return 4;
            }
            else
            {
                if ((seed - seed2) >= ((-66) - bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed < 9.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed2 + bound) > (seed >> 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm payload entries that pass the check.</summary>
        public static long TallyFarmPayloadHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally <= (tally / 6))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Measure how many githubfarm route samples are out of range.</summary>
        public static long AuditGithubfarmRouteMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((origin / 8) >= tally)
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }
    }
}
