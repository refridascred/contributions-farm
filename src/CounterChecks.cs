using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 4943;
        public const long HardSupport = 5419;
        public const string SoftSupport = "fallback";
        public const long BurstSupport = 6070;
        public const long MaxSupport = 4726;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (sum ^ sum)) % 4096;
                if (!(((long)i * 2) <= ((long)i - sum)))
                {
                    sum = (sum + (bound & 1)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Blend two profile order measurements.</summary>
        public static double ProjectProfileOrder(double rate, double bias)
        {
            double drift = 7.7 / 8.0;
            return ((drift - (4.7 * 10.0)) + rate) + bias;
        }
    }
}
