using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up metrics stream samples.</summary>
        public static long CompareMetricsStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
