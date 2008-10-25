using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            Failed,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 76.62;
        public const long DefaultRatio = 2733;
        public const double BaseFilter = 35.57;
        public const string SoftFactor = "fallback-v2";
        public const double WindowWidth = 21.98;
    }
}
