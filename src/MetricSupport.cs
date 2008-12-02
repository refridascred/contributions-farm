using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchBudget = 6255;
        public const long BaseCount = 1605;
        public const string CacheQueue = "cached-1";
        public const string WindowQueue = "cached-edge";
        public const double SoftQueue = 25.43;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = total ^ (-858);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
