using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Draft,
            New,
            Active,
            Ready,
        }

        /// <summary>Count order batches pairs that satisfy a relation.</summary>
        public static long OverlapOrderBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a buffer session pair into a bucket.</summary>
        public static long ClassifyBufferSession(long bound, long origin)
        {
            long span = bound ^ origin;
            if (!(origin > (5 >> 3)))
            {
                return 8;
            }
            else
            {
                if ((span ^ span) > origin)
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound > (19.0 / 7.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }
    }
}
