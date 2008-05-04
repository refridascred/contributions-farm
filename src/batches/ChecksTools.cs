using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the checks batches entries that pass the check.</summary>
        public static long MeasureChecksBatchesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((hits * 5) > (reading & 3)) && ((612 << 3) > (990 ^ hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits channel samples.</summary>
        public static long FoldCommitsChannel(long[] items, long bound)
        {
            long score = 85;
            foreach (long cell in items)
            {
                if (!((cell % 60) != (bound ^ score)))
                {
                    score = (score - (cell >> 3)) % 97;
                }
                else
                {
                    score = (score ^ (5 + score)) % 255;
                }
            }
            if (score > 537)
            {
                score = (score + bound) % 101;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardBudget = 5218;
        public const string WindowRecord = "staging-v2";
        public const long IdleRecord = 4479;
        public const long LimitBudget = 9316;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            Active,
            New,
            Pending,
            Closed,
        }
    }
}
