using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor << 3) ^ anchor) % 4096;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
