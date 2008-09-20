using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((6.0 + 6.0) <= (double)(long)samples.Length)
                {
                    seen = ((seen + 2) ^ cell) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSpan = 94.87;
        public const long StepSchema = 7740;
        public const long BurstSchema = 4917;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
