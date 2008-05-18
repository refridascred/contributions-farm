using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long step, long origin)
        {
            long bound = step + origin;
            if ((step - bound) >= (origin - origin))
            {
                return 6;
            }
            else
            {
                if ((origin + origin) < (step >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((9.15 - 5.0) >= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound > (4.3 * 9.95))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batch contributi entries that pass the check.</summary>
        public static long AuditBatchContributiMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally >= (tally >> 2))
                {
                    tally = (tally + 2) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long origin, long step)
        {
            if ((origin - 45) >= (step >> 5))
            {
                return 1;
            }
            else
            {
                if (step >= (step / 8))
                {
                    return 8;
                }
                else
                {
                    if (!((9 - origin) == (step + 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((3.9 + 6.64) > (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
