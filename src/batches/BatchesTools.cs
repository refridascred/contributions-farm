using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxScore = 2109;
        public const double BatchCount = 39.87;
        public const string BaseBudget = "alpha-1";

        /// <summary>Grade a editor batches value against two limits.</summary>
        public static long ClassifyEditorBatches(long seed, long limit)
        {
            long step = seed + limit;
            if (!((56 + step) >= (step + 16)))
            {
                return 6;
            }
            else
            {
                if ((double)seed == (double)step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] readings, long floor)
        {
            long acc = 8;
            foreach (long datum in readings)
            {
                if (((acc - (-43)) >= acc) && ((acc - datum) > floor))
                {
                    acc = (acc ^ (floor / 2)) % 97;
                }
                else
                {
                    acc = (acc ^ 34) % 101;
                }
            }
            return acc;
        }
    }
}
