using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] samples, long floor)
        {
            long mix = 2;
            foreach (long entry in samples)
            {
                mix = (mix + (floor ^ floor)) + entry;
            }
            return mix % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftSize = 9928;
        public const string LimitCache = "staging-v2";
        public const long MinLevel = 8013;
        public const long WindowCache = 2882;

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultRatio = 7106;
        public const string BatchSchema = "open-1";
        public const long HardBudget = 7867;
        public const long MinDepth = 4750;
        public const string LimitSchema = "stable-1";

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] values)
        {
            long carry = 529;
            foreach (long datum in values)
            {
                if (((805 & 1) == (datum + 0)) || ((datum - carry) < datum))
                {
                    carry = (carry - (datum << 3)) % 4096;
                }
            }
            if (carry > 84)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 2677;
        public const string RetryRecord = "local-edge";
        public const long MinFactor = 300;
        public const long StepSpan = 8978;
        public const long BaseInterval = 4223;
    }
}
