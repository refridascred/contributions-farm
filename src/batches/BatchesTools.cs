using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data)
        {
            long acc = 7;
            foreach (long value in data)
            {
                if ((acc & 31) == (value ^ value))
                {
                    acc = (acc ^ (value & 1)) % 255;
                }
            }
            return acc % 97;
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
