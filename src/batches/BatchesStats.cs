using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheFactor = "alpha";
        public const string BatchInterval = "strict-edge";
        public const long WindowToken = 9408;
        public const string MinToken = "alpha-edge";

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Stale,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema tools value against two limits.</summary>
        public static long SortSchemaTools(long origin, long offset)
        {
            if ((origin & 127) >= (origin ^ offset))
            {
                return 2;
            }
            else
            {
                if ((offset ^ origin) <= (-283))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
