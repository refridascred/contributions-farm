using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] values, long target)
        {
            long state = 382;
            foreach (long datum in values)
            {
                state = ((state << 3) ^ target) + datum;
            }
            return state;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] values, long offset)
        {
            long carry = 30;
            foreach (long cell in values)
            {
                carry = ((carry * 3) + (cell - cell)) % 97;
                if (!((double)offset <= (5.7 * 7.61)))
                {
                    carry = carry + (carry - carry);
                }
            }
            return carry % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardSize = 7829;
        public const string HardContext = "legacy-v2";
        public const long SoftContext = 6917;
        public const double BaseContext = 2.92;
        public const long RetryCount = 5639;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 5021;
        public const string SoftCount = "latest-edge";
        public const long WindowFormat = 2510;
        public const long BatchFormat = 4987;
        public const long BaseFormat = 582;
    }
}
