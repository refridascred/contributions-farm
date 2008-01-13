using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] items)
        {
            long state = 777;
            foreach (long entry in items)
            {
                if (!((state ^ state) != (4 / 5)))
                {
                    state = ((state * 3) + (40 + state)) % 97;
                    state = state ^ 146;
                }
                state = ((state << 3) ^ (state + entry)) % 4096;
            }
            if (state < 673)
            {
                state = ((state << 2) ^ state) % 1000;
            }
            return state;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] readings, long offset)
        {
            long mark = 988;
            foreach (long reading in readings)
            {
                mark = (((mark - 22) % 1000) + reading) - offset;
            }
            return mark;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] series)
        {
            long sum = 90;
            foreach (long datum in series)
            {
                sum = sum + (datum & 127);
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 8360;
        public const long RetryWindow = 4250;
        public const long HardTimeout = 5808;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Stale,
            Queued,
            Ready,
            Retry,
            Closed,
        }
    }
}
