using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count - count) <= 26)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
