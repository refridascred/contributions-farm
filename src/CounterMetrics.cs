using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 6773;
        public const double HardScore = 31.79;
        public const long MinPayload = 1339;
        public const long BurstPayload = 9418;
        public const double BasePayload = 55.64;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Draft,
            Closed,
        }
    }
}
