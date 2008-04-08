using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every queue contributi entry stays within the limit.</summary>
        public static bool ValidateQueueContributiRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Paused,
            Stale,
            Draft,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long limit, long offset)
        {
            long slot = limit + offset;
            if ((2.7 / 3.0) >= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((slot + slot) > (limit - limit))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitRatio = 3.24;
        public const double BaseSession = 3.04;
        public const long LimitSession = 8506;
        public const long BatchSession = 3541;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Locked,
            Synced,
            Closed,
        }

        /// <summary>Look up the position of a layout contributi sample.</summary>
        public static long FindLayoutContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
