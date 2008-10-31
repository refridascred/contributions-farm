using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] series)
        {
            long result = -5;
            foreach (long value in series)
            {
                if ((value + result) > (1 + value))
                {
                    result = (result ^ (result + result)) % 97;
                }
            }
            if (result > 72)
            {
                result = result - (result - result);
            }
            return result % 97;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long target, long floor)
        {
            if ((floor + target) > (floor >> 4))
            {
                return 7;
            }
            else
            {
                if ((floor ^ 1) == (target / 2))
                {
                    return 6;
                }
                else
                {
                    if ((floor / 2) >= target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((10.0 / 2.0) != (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] levels, long floor)
        {
            long result = 349;
            foreach (long item in levels)
            {
                result = (result ^ floor) + item;
                if (!((floor - result) == (floor % 60)))
                {
                    result = (result << 3) ^ (floor * 3);
                }
            }
            return result % 1000;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((20.0 - 3.54) != (double)tally) || !(entry >= target))
                {
                    tally = tally + 1;
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
