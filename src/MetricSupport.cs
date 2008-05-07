using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((cell >> 1) >= (matches ^ 90)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRecord = 1.84;
        public const string LimitRecord = "open";
        public const double MaxLevel = 10.37;
        public const string BurstRatio = "stable-1";
        public const string BurstTimeout = "standard";

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
