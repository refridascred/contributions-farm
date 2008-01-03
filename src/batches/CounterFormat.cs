using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 3743;
        public const double CacheTimeout = 82.63;
        public const double WindowInterval = 36.1;

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] samples, long offset)
        {
            long sum = 750;
            foreach (long datum in samples)
            {
                sum = ((sum ^ (offset * 2)) % 65521) ^ datum;
            }
            if (sum > 383)
            {
                sum = sum - (sum + sum);
            }
            return sum;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Idle,
            Closed,
            Ready,
        }
    }
}
