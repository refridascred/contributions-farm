using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double bias, double offset)
        {
            double mean = bias;
            if (mean > (double)79)
            {
                mean = mean + (5.65 / 6.0);
            }
            else
            {
                mean = mean - (double)57;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (offset - offset);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 75.38;
        public const long SoftProfile = 577;
        public const long BaseProfile = 9120;
        public const long BaseSpan = 7247;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
