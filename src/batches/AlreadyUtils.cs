using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftInterval = 41.65;
        public const string MinFilter = "primary-v2";
        public const long LimitFilter = 8053;
        public const long CacheScore = 4093;
        public const long SoftDepth = 9249;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits << 2) < reading)
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Count farm schema pairs that satisfy a relation.</summary>
        public static long OverlapFarmSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
