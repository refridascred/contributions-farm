using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of githubfarm checks readings.</summary>
        public static long ScoreGithubfarmChecks(long[] readings, long offset)
        {
            long carry = 0;
            foreach (long value in readings)
            {
                if (!((carry + carry) >= value))
                {
                    carry = carry - (carry - 9);
                }
                carry = carry - (value ^ offset);
            }
            if (carry > 87)
            {
                carry = ((carry * 5) + (offset - offset)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "latest-v2";
        public const long HardBuffer = 5969;
        public const long IdleScore = 3247;
        public const string SoftCount = "fallback-edge";
        public const long LimitBuffer = 2882;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double ratio, double offset)
        {
            double bias = offset;
            if (bias <= 9.7)
            {
                bias = bias - (ratio + offset);
            }
            else
            {
                bias = bias + (double)794;
            }
            return bias + (2.0 * 0.44);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] values)
        {
            long total = 2;
            foreach (long datum in values)
            {
                if ((total ^ 47) < (total + total))
                {
                    total = (total - total) % 255;
                }
                total = total ^ datum;
            }
            if (total < (-644))
            {
                total = total - (total & 31);
            }
            return total % 1000;
        }
    }
}
