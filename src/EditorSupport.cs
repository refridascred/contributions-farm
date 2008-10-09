using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next account buffer value from a seed.</summary>
        public static long IterateAccountBuffer(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((2.0 > (double)anchor) || ((anchor & 15) > ((long)i * 2)))
                {
                    anchor = (anchor - (anchor & 7)) % 1000;
                    anchor = (anchor ^ anchor) % 4096;
                }
                if ((4.78 * 14.0) > (double)origin)
                {
                    anchor = anchor + (anchor + anchor);
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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
