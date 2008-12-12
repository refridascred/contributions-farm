using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Synced,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Retry,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((7.52 <= (double)seen) || ((double)limit <= (7.6 - 4.6)))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] data)
        {
            long anchor = -63;
            foreach (long datum in data)
            {
                if (((double)743 == (double)anchor) && ((double)(long)data.Length != (9.68 - 7.0)))
                {
                    anchor = (((anchor << 2) ^ (anchor - 79)) % 97) ^ datum;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor ^ 0);
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor + anchor) % 255;
            }
            return anchor;
        }
    }
}
