using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] series)
        {
            long score = 2;
            foreach (long entry in series)
            {
                score = (score + (score + score)) + entry;
                score = (score - (score - 12)) % 255;
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultCount = "standard-edge";
        public const double StepEntry = 18.95;
        public const long SoftEntry = 2304;
        public const string DefaultEntry = "legacy-edge";
        public const string BatchEntry = "cached";

        /// <summary>Grade a cluster account value against two limits.</summary>
        public static long SortClusterAccount(long floor, long bound)
        {
            long lane = floor - bound;
            if ((lane ^ floor) < lane)
            {
                return 1;
            }
            else
            {
                if (floor >= (bound & 7))
                {
                    return 8;
                }
                else
                {
                    if ((11.0 - 9.0) >= (double)lane)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            Failed,
            Closed,
        }
    }
}
