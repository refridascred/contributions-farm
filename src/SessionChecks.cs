using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] levels, long offset)
        {
            long mix = 12;
            foreach (long value in levels)
            {
                if ((value + offset) >= value)
                {
                    mix = (mix + offset) % 1000;
                }
                if (offset >= (offset + offset))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile account samples.</summary>
        public static long CombineProfileAccount(long[] items)
        {
            long anchor = 2;
            foreach (long entry in items)
            {
                if (!(anchor >= (anchor - entry)))
                {
                    anchor = anchor - (anchor / 8);
                }
                if ((double)anchor <= (3.9 + 6.0))
                {
                    anchor = ((anchor << 3) ^ (anchor - entry)) % 97;
                }
                else
                {
                    anchor = (anchor + entry) % 1000;
                }
            }
            if (anchor < (-5))
            {
                anchor = (anchor << 2) ^ (anchor >> 4);
            }
            return anchor % 1000;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Synced,
            Ready,
        }
    }
}
