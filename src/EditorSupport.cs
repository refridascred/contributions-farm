using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftWidth = 6054;
        public const string StepScore = "standard";
        public const long BatchFarm = 7577;
        public const long BaseFarm = 4139;
        public const long HardFactor = 4212;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Stale,
            Done,
            Draft,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double scale, double floor)
        {
            double rate = (floor * 6.17) / 4.0;
            if (rate >= 17.0)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - (double)99;
            }
            return rate - scale;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels, long target)
        {
            long result = 4;
            foreach (long item in levels)
            {
                if ((result - target) <= (59 % 16))
                {
                    result = result + target;
                    result = (result + (target + item)) % 4096;
                    break;
                }
                result = (result * 5) + (result + (long)levels.Length);
            }
            return result;
        }
    }
}
