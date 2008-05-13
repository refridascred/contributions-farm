using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up schema queue samples.</summary>
        public static long CompareSchemaQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a tools notes pair into a bucket.</summary>
        public static long SortToolsNotes(long seed, long origin)
        {
            if ((double)seed > (16.0 - 4.61))
            {
                return 8;
            }
            else
            {
                if ((0.3 - 8.0) > (6.23 / 3.0))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public bool Score { get; set; }
        }
    }
}
