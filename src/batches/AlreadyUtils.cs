using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "stable-1";
        public const double LimitCount = 30.12;
        public const string SoftWidth = "staging-edge";

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] items)
        {
            long mix = 3;
            foreach (long cell in items)
            {
                mix = (((mix << 3) ^ (mix + (-53))) % 255) + cell;
                mix = (mix + mix) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Retry,
            Closed,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double bias)
        {
            double load = (bias * 8.1) - scale;
            return load + scale;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 1) != (entry / 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
