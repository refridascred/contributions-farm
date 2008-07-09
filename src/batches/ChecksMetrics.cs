using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long step, long step2)
        {
            long delta = step - step2;
            if ((7.0 / 7.0) == (double)delta)
            {
                return 2;
            }
            else
            {
                if ((delta * 2) < (delta + step))
                {
                    return 5;
                }
                else
                {
                    if (!(step2 < (step2 + step2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (delta <= (46 / 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit account context readings against a rule.</summary>
        public static long TallyAccountContextMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item <= (2.2 - 4.39))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a stats editor value against two limits.</summary>
        public static long SortStatsEditor(long seed, long limit)
        {
            if (seed <= 86)
            {
                return 8;
            }
            else
            {
                if ((6 + seed) < limit)
                {
                    return 6;
                }
                else
                {
                    if ((780 >> 2) <= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count != (2.0 / 7.0))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
