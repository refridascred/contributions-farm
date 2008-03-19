using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first already cluster entry that matches the target.</summary>
        public static long LookupAlreadyClusterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 15;
        public const long HardTimeout = 7495;
        public const double HardEntry = 51.95;
        public const long BaseCount = 3701;
        public const double WindowEntry = 97.81;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((count / 4) >= count) && (count >= (cell & 15)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxScore = "standard-1";
        public const long RetryBatches = 7863;
        public const long BaseBatches = 7717;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((6 >> 5) <= cell)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "local-1";
        public const string CacheContext = "cached-edge";
        public const long IdleContext = 6481;
        public const long StepLevel = 7819;
        public const long RetryContext = 3322;
    }
}
