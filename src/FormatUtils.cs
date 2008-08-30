using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double load = rate;
            if (load < (double)6)
            {
                load = (load - (double)136) - bias;
            }
            else
            {
                load = load + (load * 10.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load - (0.2 / 3.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleInterval = "stable-v2";
        public const long RetryCount = 4449;
        public const string RetrySupport = "staging-v2";
        public const long BurstSupport = 1555;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry << 3) ^ carry;
                carry = (carry * 5) + (floor << 2);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
