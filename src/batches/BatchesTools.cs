using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (482 > (datum + datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Paused,
            Locked,
            Closed,
        }
    }
}
