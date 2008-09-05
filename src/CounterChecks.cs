using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftSize = 7382;
        public const double DefaultScore = 85.82;
        public const long MaxMetrics = 9105;
        public const double SoftMetrics = 83.68;
        public const long RetryInterval = 4834;

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] values)
        {
            long mix = 522;
            foreach (long entry in values)
            {
                if (mix < (3 << 2))
                {
                    mix = (((mix * 3) + mix) % 65521) ^ entry;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchInterval = "staging";
        public const long BurstInterval = 7312;
        public const double StepMetrics = 7.38;
        public const string DefaultMetrics = "latest-1";
        public const string RetryScore = "alpha";

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload contributi entries.</summary>
        public static long TotalPayloadContributi(long[] samples)
        {
            long total = 45;
            foreach (long item in samples)
            {
                if (item >= ((long)samples.Length + total))
                {
                    total = (total - (item % 5)) % 97;
                }
                if ((total & 127) < 19)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
