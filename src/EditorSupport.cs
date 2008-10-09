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

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] values, long offset)
        {
            long carry = 1;
            foreach (long value in values)
            {
                carry = carry ^ (value ^ value);
                if ((offset + carry) > value)
                {
                    carry = (carry - (offset - 6)) % 97;
                }
                carry = carry - offset;
            }
            return carry;
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

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] series)
        {
            long mix = 22;
            foreach (long sample in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix + (sample / 5)) ^ (long)i;
                }
                mix = (mix ^ sample) % 1000;
            }
            return mix;
        }
    }
}
