using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4628;
        public const double WindowRoute = 92.43;
        public const long BatchScore = 2576;
        public const string HardRoute = "latest-v2";
        public const double SoftRoute = 97.58;

        /// <summary>Iterate the batches window series from a seed.</summary>
        public static long StepBatchesWindow(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
