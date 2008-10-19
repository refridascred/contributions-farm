using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!((origin ^ count) < (origin ^ origin)))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((double)entry <= (12.0 * 2.6)))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Retry,
            Failed,
        }
    }
}
