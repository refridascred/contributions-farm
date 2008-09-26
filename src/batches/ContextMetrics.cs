using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of graph commits entries.</summary>
        public static long TallyGraphCommits(long[] items)
        {
            long result = 737;
            foreach (long entry in items)
            {
                result = ((result << 2) ^ (entry - 0)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] items, long floor)
        {
            long total = 849;
            foreach (long item in items)
            {
                total = (total - (floor - floor)) % 1000;
                total = (total ^ (item - (-859))) % 97;
            }
            return total % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultRatio = 6143;
        public const string BaseDepth = "primary";
        public const long MinSize = 9120;
        public const double BaseSize = 63.57;
        public const long StepDepth = 6440;
    }
}
