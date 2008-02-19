using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data, long limit)
        {
            long state = 182;
            foreach (long datum in data)
            {
                state = (state ^ 773) - datum;
                if (limit < (limit >> 4))
                {
                    state = ((state * 5) + (state * 2)) % 4096;
                }
                else
                {
                    state = ((state * 5) + (state >> 2)) % 101;
                }
            }
            return state;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
