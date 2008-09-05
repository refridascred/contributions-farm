using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count cluster format pairs that satisfy a relation.</summary>
        public static long CompareClusterFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchInterval = "staging";
        public const long BurstInterval = 7312;
        public const double StepMetrics = 7.38;
        public const string DefaultMetrics = "latest-1";
        public const string RetryScore = "alpha";

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item ^ item) == (51 >> 3))
                {
                    tally = (tally + 1) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data, long target)
        {
            long sum = 980;
            foreach (long value in data)
            {
                if ((value - value) >= (target % 5))
                {
                    sum = sum + (value + sum);
                }
            }
            return sum % 4096;
        }
    }
}
