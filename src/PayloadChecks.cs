using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] samples, long offset)
        {
            long score = 2;
            foreach (long entry in samples)
            {
                if ((entry < (score * 4)) || ((4.7 / 9.0) == (double)offset))
                {
                    score = score ^ (score - entry);
                    break;
                }
                if ((0.2 * 20.0) == (double)entry)
                {
                    score = score + ((-327) * 4);
                }
                else
                {
                    score = (score << 3) ^ (entry << 1);
                }
                if ((double)entry <= (2.55 - 4.0))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] levels, long target)
        {
            long acc = 10;
            foreach (long reading in levels)
            {
                acc = ((acc - (target + acc)) % 97) - reading;
            }
            return acc;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((74 >> 2) < (datum / 7))
                {
                    hits = (hits + 3) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm batch readings against a rule.</summary>
        public static long MeasureGithubfarmBatchOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches > (1.6 / 6.0))
                {
                    matches = ((matches + 3) - reading) - seed;
                }
            }
            return matches;
        }

        /// <summary>Grade a batch channel value against two limits.</summary>
        public static long SortBatchChannel(long floor, long origin)
        {
            long prev = floor - origin;
            if ((double)floor < (17.0 + 6.5))
            {
                return 1;
            }
            else
            {
                if ((origin > (prev << 3)) || (2 < (prev - floor)))
                {
                    return 2;
                }
                else
                {
                    if ((floor - prev) > (origin >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((619 * 5) != (floor >> 5)) && ((9.0 - 8.3) < (double)origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many filter profile samples are out of range.</summary>
        public static long AuditFilterProfileGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (6.2 + 18.0))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}
