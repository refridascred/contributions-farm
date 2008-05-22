using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the schema report entries that pass the check.</summary>
        public static long MeasureSchemaReportHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count + bound) <= count)
                {
                    count = (count + 2) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item >> 1) > (765 << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
