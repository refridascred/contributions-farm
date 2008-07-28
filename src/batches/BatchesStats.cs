using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (limit << 2)) % 97;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 6117;
        public const double BurstRatio = 84.92;
        public const long HardRecord = 3816;
        public const long MaxRecord = 7609;
        public const double WindowFactor = 92.3;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Locked,
            Draft,
            Active,
            Pending,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                long seen = ((-446) % 5) << 2;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    seen = ((seen + (result << 1)) % 1000) ^ (long)i2;
                    result = result ^ (seen ^ bound);
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
