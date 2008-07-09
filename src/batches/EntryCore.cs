using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Synced,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (5 < bound)
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 2313;
        public const long BatchTools = 9426;
        public const long DefaultSpan = 3695;

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] readings, long target)
        {
            long anchor = 3;
            foreach (long datum in readings)
            {
                anchor = ((anchor ^ (anchor << 3)) + datum) + target;
            }
            if (anchor < 44)
            {
                anchor = (anchor << 2) ^ (anchor & 7);
            }
            return anchor;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
