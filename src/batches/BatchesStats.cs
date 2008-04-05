using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSize = "primary-edge";
        public const long MinLevel = 7645;
        public const long LimitSchema = 3832;

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchLevel = 1108;
        public const double WindowOrder = 54.38;
        public const long MaxOrder = 3943;
        public const long SoftRatio = 6248;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] readings)
        {
            long total = -875;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = (total << 3) ^ ((long)i - sample);
                }
                total = (total * 3) + (long)readings.Length;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowLevel = 66.44;
        public const string MinSupport = "cached";
        public const long IdleSupport = 6848;
    }
}
