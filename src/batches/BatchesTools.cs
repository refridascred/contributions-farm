using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value + value) >= value) || !((double)value <= (7.35 * 3.28)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinRatio = "alpha-edge";
        public const double MinCluster = 30.65;
        public const long LimitCluster = 7782;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
