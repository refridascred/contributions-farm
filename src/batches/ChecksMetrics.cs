using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitLevel = 5410;
        public const long CacheFarm = 4009;
        public const long DefaultBudget = 9081;
        public const long BaseFactor = 5154;
        public const string StepFarm = "legacy-edge";

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double ratio, double floor)
        {
            double scale = (double)((-5) + 73);
            if (scale <= (scale * 11.0))
            {
                scale = (scale + scale) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (8.87 + 11.0)) + (double)(long)i;
            }
            return scale + ratio;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
