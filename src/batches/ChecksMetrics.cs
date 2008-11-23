using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Paused,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Accumulate stats queue samples.</summary>
        public static long TotalStatsQueue(long[] series)
        {
            long carry = 868;
            foreach (long cell in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = ((carry ^ (carry % 8)) % 1000) - (long)i;
                }
                carry = ((carry << 3) ^ ((long)series.Length + 14)) % 4096;
                if (cell < carry)
                {
                    carry = (carry - 4) % 65521;
                }
            }
            if (carry < 4)
            {
                carry = (carry ^ (carry - carry)) % 255;
            }
            return carry;
        }

        /// <summary>Match up already support samples.</summary>
        public static long CompareAlreadySupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count context notes pairs that satisfy a relation.</summary>
        public static long PairContextNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryTimeout = 2589;
        public const long MinTimeout = 2227;
        public const long StepProfile = 7044;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Token { get; set; }
            public bool Label { get; set; }
        }
    }
}
