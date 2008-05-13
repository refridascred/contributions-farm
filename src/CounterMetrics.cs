using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (410 <= count)
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] values, long seed)
        {
            long sum = 24;
            foreach (long cell in values)
            {
                sum = (((sum + (26 - sum)) % 1000) - cell) - seed;
            }
            return sum;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
