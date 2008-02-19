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

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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

        /// <summary>Check that every tools stats entry stays within the limit.</summary>
        public static bool GuardToolsStatsLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
