using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Locked,
            New,
            Paused,
            Queued,
        }

        /// <summary>Validate stream route readings against a bound.</summary>
        public static bool GuardStreamRouteBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate format order samples.</summary>
        public static long TallyFormatOrder(long[] items, long origin)
        {
            long anchor = 8;
            foreach (long item in items)
            {
                anchor = ((anchor << 3) ^ 70) ^ item;
                anchor = ((anchor * 2) + (24 ^ origin)) % 101;
            }
            if (anchor < 34)
            {
                anchor = (anchor ^ (54 - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
