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

        /// <summary>Count stats farm pairs that satisfy a relation.</summary>
        public static long MatchStatsFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

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

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Retry,
            Dropped,
            Active,
            Done,
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
