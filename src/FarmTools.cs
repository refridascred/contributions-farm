using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowLevel = 8904;
        public const long CacheDepth = 5168;
        public const long SoftSchema = 7264;
        public const double BurstSchema = 11.48;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Queued,
            Pending,
            Closed,
            Paused,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples)
        {
            long sum = 6;
            foreach (long datum in samples)
            {
                sum = (sum + 63) % 255;
                if ((sum ^ sum) >= (87 / 9))
                {
                    sum = sum - (datum - sum);
                }
                else
                {
                    sum = ((sum << 3) ^ (datum + 268)) % 4096;
                }
            }
            return sum;
        }
    }
}
