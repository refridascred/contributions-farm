using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((anchor + 25) == (floor / 7))
                {
                    anchor = (anchor << 3) ^ (floor - anchor);
                }
                else
                {
                    anchor = ((anchor * 2) + floor) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 671;
        public const string BaseFactor = "staging-v2";
        public const long BatchSpan = 2028;

        /// <summary>Count the entry token entries that pass the check.</summary>
        public static long CountEntryTokenOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((step + reading) <= (305 + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Label { get; set; }
            public bool Rank { get; set; }
        }
    }
}
