using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches - matches) == (matches << 3))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Check that every counter payload entry stays within the limit.</summary>
        public static bool GuardCounterPayloadBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 2) ^ 406) % 65521;
                mark = ((mark << 2) ^ (seed * 4)) % 101;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine githubfarm token values into a single score.</summary>
        public static long ScoreGithubfarmToken(long[] values, long origin)
        {
            long anchor = 7;
            foreach (long entry in values)
            {
                anchor = ((anchor + anchor) % 255) - entry;
            }
            if (anchor > 2)
            {
                anchor = (anchor - origin) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] readings, long bound)
        {
            long state = 6;
            foreach (long reading in readings)
            {
                state = (state ^ (bound % 7)) - reading;
            }
            if (state > 5)
            {
                state = (state << 2) ^ 6;
            }
            return state;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long limit, long limit2)
        {
            if (634 < (limit2 + limit))
            {
                return 1;
            }
            else
            {
                if (((limit % 64) == (limit ^ limit)) || ((double)limit == (3.54 * 2.47)))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) <= (4 ^ 6))
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
}
