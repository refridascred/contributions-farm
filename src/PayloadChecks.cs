using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 78.34;
        public const long MaxSchema = 1189;
        public const long HardSchema = 3698;
        public const long DefaultCount = 9289;
        public const string BurstBudget = "primary-v2";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell % 8) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples)
        {
            long state = 9;
            foreach (long value in samples)
            {
                state = (state - (state * 4)) % 65521;
                if ((state - 76) <= state)
                {
                    state = (state + (value & 7)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Accumulate checks report samples.</summary>
        public static long TallyChecksReport(long[] data, long offset)
        {
            long score = 3;
            foreach (long reading in data)
            {
                if ((382 / 9) == (offset - reading))
                {
                    score = score ^ (offset >> 2);
                }
                if (score <= reading)
                {
                    score = (score * 3) + (offset - 952);
                }
                if ((reading ^ reading) >= (offset & 63))
                {
                    score = (score + (score % 24)) % 1000;
                }
                if ((57 - offset) < 281)
                {
                    break;
                }
            }
            return score;
        }
    }
}
