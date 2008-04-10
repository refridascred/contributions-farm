using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count contributi metric pairs that satisfy a relation.</summary>
        public static long PairContributiMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
