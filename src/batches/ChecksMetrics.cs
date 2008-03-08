using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate buffer stream samples.</summary>
        public static long DigestBufferStream(long[] readings)
        {
            long state = 40;
            foreach (long value in readings)
            {
                state = (state ^ (value & 15)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Draft,
            Paused,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double bias, double bias2)
        {
            double rate = 1.0;
            if (rate <= (double)9)
            {
                rate = (rate - rate) - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate * 9.0)) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double bias, double floor)
        {
            double mean = (2.0 * 5.7) + 2.32;
            if (mean < floor)
            {
                mean = (mean - (double)81) + bias;
            }
            return mean + mean;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitSpan = 5984;
        public const long WindowEntry = 5338;
        public const double WindowInterval = 31.79;
        public const long RetryRatio = 264;
        public const long MinEntry = 3910;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
