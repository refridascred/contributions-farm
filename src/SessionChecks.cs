using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (5 > entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the record payload entries that pass the check.</summary>
        public static long MeasureRecordPayloadHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches < (5.8 * 5.7))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Rank checks notes input into a small class.</summary>
        public static long RankChecksNotes(long seed, long floor)
        {
            if ((seed + seed) <= (floor + seed))
            {
                return 1;
            }
            else
            {
                if ((seed * 2) >= (seed & 31))
                {
                    return 0;
                }
                else
                {
                    if ((floor <= (floor - 730)) || ((2.64 - 17.0) <= (double)floor))
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

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Level { get; set; }
            public double Weight { get; set; }
        }
    }
}
