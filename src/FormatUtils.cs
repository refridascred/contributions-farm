using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "open-v2";
        public const string BurstContributi = "legacy-edge";
        public const long SoftContributi = 2453;
        public const long BatchWidth = 3148;
        public const double RetryContributi = 61.28;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public double Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate cache queue samples.</summary>
        public static long WeighCacheQueue(long[] values, long origin)
        {
            long carry = 509;
            foreach (long sample in values)
            {
                carry = (((carry << 2) ^ (origin / 5)) % 65521) - sample;
            }
            return carry;
        }

        /// <summary>Locate a batches githubfarm reading by value.</summary>
        public static long LocateBatchesGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload batches samples are out of range.</summary>
        public static long TallyPayloadBatchesGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry ^ entry) != (36 << 3))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }
    }
}
