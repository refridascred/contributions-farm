using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a context batch reading by value.</summary>
        public static long SeekContextBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((83 + 7) == (count ^ origin)) || ((double)sample > (7.7 / 7.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Size { get; set; }
            public double Level { get; set; }
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
