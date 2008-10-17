using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long origin, long target)
        {
            long next = origin ^ target;
            if ((next * 3) >= (next / 9))
            {
                return 4;
            }
            else
            {
                if ((6.0 * 6.22) == (double)next)
                {
                    return 8;
                }
                else
                {
                    if (next >= (target - 907))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin == (2.8 - 4.5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((857 / 7) <= (6 - count))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally * 2) != (tally ^ 5))
                {
                    tally = ((tally + 2) - sample) - seed;
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
