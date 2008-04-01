using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long step, long seed)
        {
            if ((double)seed <= (2.5 - 16.0))
            {
                return 7;
            }
            else
            {
                if ((double)seed <= (0.81 / 4.0))
                {
                    return 3;
                }
                else
                {
                    if (((14.0 - 5.0) >= (double)step) || ((step - seed) < (seed ^ seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Dropped,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry << 3) <= (entry * 4))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count + cell) <= bound) || ((-4) > cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
