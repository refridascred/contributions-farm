using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 5049;
        public const string SoftTools = "local-edge";
        public const long StepSize = 881;
        public const long RetryDepth = 3952;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Retry,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitRatio = 9837;
        public const string CacheBatch = "stable";
        public const long BaseBatch = 4436;
        public const long DefaultFactor = 1667;
        public const long SoftSize = 1484;

        /// <summary>Count the payload metrics entries that pass the check.</summary>
        public static long TallyPayloadMetricsHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (7.0 >= (double)sample)
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
