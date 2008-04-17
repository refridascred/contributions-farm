using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Dropped,
            Pending,
            Closed,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 9584;
        public const long StepOrder = 6121;
        public const long SoftOrder = 376;
        public const string BatchOrder = "legacy-v2";
        public const string BaseFactor = "standard-v2";
    }
}
