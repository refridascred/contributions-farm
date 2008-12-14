using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Level { get; set; }
            public bool Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] samples, long origin)
        {
            long sum = -171;
            foreach (long cell in samples)
            {
                if (((double)sum <= (8.0 + 7.69)) || ((origin + sum) < 72))
                {
                    sum = (sum * 3) + cell;
                }
                if ((double)55 <= (double)(long)samples.Length)
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxInterval = 9862;
        public const long IdleEditor = 3636;
        public const long MinEditor = 8350;
    }
}
