using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = result ^ result;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many editor schema samples are out of range.</summary>
        public static long TallyEditorSchemaOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((origin * 2) <= 0) || (50 <= (entry & 255)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
