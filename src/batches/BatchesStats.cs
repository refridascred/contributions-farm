using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((0.99 / 8.0) < (double)entry) || (entry < (seed - 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine buffer notes values into a single score.</summary>
        public static long WeighBufferNotes(long[] items, long step)
        {
            long sum = -174;
            foreach (long reading in items)
            {
                sum = (sum ^ (step + step)) + reading;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleScore = 7936;
        public const long CacheSize = 2321;
        public const long MinOrder = 3303;
        public const double RetryOrder = 28.05;

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftTimeout = 9374;
        public const long HardCommand = 8998;
        public const double IdleCommand = 21.21;
        public const double SoftCommand = 76.08;
    }
}
