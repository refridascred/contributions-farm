using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] series)
        {
            long mix = 976;
            foreach (long entry in series)
            {
                if (((482 & 3) >= (entry - 20)) || ((mix + entry) > entry))
                {
                    mix = (mix + (entry / 3)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 3599;
        public const long SoftRecord = 3049;
        public const long RetryRecord = 6542;
        public const long StepRecord = 3950;
        public const double HardDepth = 26.59;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] samples)
        {
            long sum = 5;
            foreach (long entry in samples)
            {
                sum = ((sum + (sum >> 4)) % 65521) ^ entry;
                sum = (sum * 2) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 2374;
        public const long WindowReport = 8709;
        public const long BurstReport = 8359;
        public const string LimitTimeout = "latest-edge";
        public const long StepDepth = 3162;
    }
}
