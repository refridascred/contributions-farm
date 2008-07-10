using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every support schema entry stays within the limit.</summary>
        public static bool CheckSupportSchemaLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleInterval = 7647;
        public const long BatchWidth = 6159;
        public const string CacheBatch = "latest-edge";
        public const long LimitBatch = 879;
        public const string HardBatch = "primary-v2";
    }
}
