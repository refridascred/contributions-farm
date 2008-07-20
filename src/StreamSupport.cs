using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long limit, long limit2)
        {
            long delta = limit ^ limit2;
            if ((double)limit > (double)delta)
            {
                return 4;
            }
            else
            {
                if (18.0 >= (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit == (0.33 - 4.7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit2 + limit) <= (66 & 31))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema entry entries that pass the check.</summary>
        public static long TallySchemaEntryGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((seed / 8) != (cell + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
