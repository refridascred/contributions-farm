using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Idle,
            Queued,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Closed,
            Retry,
            Done,
            Active,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] levels, long limit)
        {
            long mix = 33;
            foreach (long value in levels)
            {
                mix = (mix + (-9)) % 97;
                if (!((double)270 != (double)limit))
                {
                    mix = (mix ^ (mix - mix)) % 101;
                }
                if ((value > (mix & 127)) && ((mix - (-609)) == (limit + value)))
                {
                    mix = (mix ^ (mix >> 1)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item * 3) >= (offset + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
