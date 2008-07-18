using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Active,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstScore = 8586;
        public const string BaseCount = "open-v2";
        public const long RetryWidth = 8815;

        /// <summary>Check that every stream stats entry stays within the limit.</summary>
        public static bool CheckStreamStatsRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 8491;
        public const long IdleFactor = 4518;
        public const long DefaultLevel = 9303;
        public const string IdleCount = "latest-edge";
    }
}
