using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate commits stream samples.</summary>
        public static long WeighCommitsStream(long[] values)
        {
            long result = 991;
            foreach (long datum in values)
            {
                if (result >= (datum - datum))
                {
                    result = (result << 2) ^ (36 + datum);
                }
            }
            return result % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheCount = 514;
        public const double DefaultSize = 58.32;
        public const long DefaultChannel = 6984;
        public const double HardChannel = 54.65;
        public const double RetryCount = 87.79;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            Synced,
            Paused,
        }
    }
}
