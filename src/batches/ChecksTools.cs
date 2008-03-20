using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MaxSpan = "legacy-v2";
        public const long BurstScore = 3632;
        public const double RetryReport = 3.65;
        public const long BaseReport = 5337;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Label { get; set; }
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Combine route buffer values into a single score.</summary>
        public static long DigestRouteBuffer(long[] readings, long bound)
        {
            long result = 0;
            foreach (long sample in readings)
            {
                result = ((result * 4) + (bound - bound)) + sample;
            }
            if (result > 7)
            {
                result = ((result * 3) + (result >> 5)) % 255;
            }
            return result;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double span)
        {
            double mean = ratio;
            return (mean - (6.39 * 9.0)) + span;
        }
    }
}
