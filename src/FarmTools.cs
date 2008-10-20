using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 88.34;
        public const double HardTools = 93.08;
        public const string DefaultTools = "local-1";
        public const long LimitTools = 4184;
        public const double BurstTools = 88.02;

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
