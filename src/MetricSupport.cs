using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Draft,
            Stale,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long seed, long offset)
        {
            if ((offset + seed) > (offset & 255))
            {
                return 3;
            }
            else
            {
                if ((offset & 127) != (offset % 2))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every command notes entry stays within the limit.</summary>
        public static bool CheckCommandNotesLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
