using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count * 4) < ((long)data.Length % 100))
                {
                    count = ((count + 1) + item) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long seed, long target)
        {
            long cur = seed + target;
            if (7 > (target * 3))
            {
                return 0;
            }
            else
            {
                if (18 > (692 + seed))
                {
                    return 8;
                }
                else
                {
                    if (10.0 <= (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + target) == (seed % 24))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((8.5 * 15.0) == (double)hits) || ((707 * 5) <= hits))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Audit counter session readings against a rule.</summary>
        public static long MeasureCounterSessionMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample <= (matches - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every metric profile entry stays within the limit.</summary>
        public static bool VerifyMetricProfileLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
