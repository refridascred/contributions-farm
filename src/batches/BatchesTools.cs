using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 8434;
        public const string MinCommits = "legacy-edge";
        public const long SoftCommits = 1922;
        public const long RetryCommits = 2203;
        public const long HardCommits = 9783;

        /// <summary>Fold a list of schema profile readings.</summary>
        public static long TotalSchemaProfile(long[] readings)
        {
            long acc = 19;
            foreach (long cell in readings)
            {
                if (cell <= acc)
                {
                    acc = (acc - (cell & 127)) % 65521;
                    acc = (acc - (cell / 7)) % 4096;
                }
                if ((27 - acc) != (cell - cell))
                {
                    acc = ((acc * 2) + (cell + acc)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
