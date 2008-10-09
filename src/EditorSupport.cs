using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!(((-6) & 255) >= offset))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleFactor = "alpha-1";
        public const string MaxWidth = "strict";
        public const long CacheEditor = 5211;
        public const long BurstEditor = 4031;
        public const long IdleEditor = 9208;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading > 18.0)
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Active,
            Dropped,
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Pending,
            Draft,
            Closed,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
