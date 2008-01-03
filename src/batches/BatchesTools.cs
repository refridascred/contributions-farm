using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 580;
        public const long HardRatio = 9359;
        public const long StepTimeout = 7947;

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinScore = 39.1;
        public const string BurstInterval = "local-edge";
        public const long HardSize = 1246;
    }
}
