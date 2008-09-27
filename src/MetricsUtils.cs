using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 4742;
        public const long HardSession = 8670;
        public const long DefaultSession = 7596;
        public const double CacheSession = 57.29;
        public const long BaseFactor = 9625;

        /// <summary>Check that every channel metrics entry stays within the limit.</summary>
        public static bool ValidateChannelMetricsLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Score { get; set; }
            public string Size { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long seed, long step)
        {
            if (((step * 5) >= step) || ((9.9 + 17.0) != (double)step))
            {
                return 7;
            }
            else
            {
                if (!((step << 1) < 7))
                {
                    return 8;
                }
                else
                {
                    if ((step - step) < (step / 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((462 ^ step) <= step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 7691;
        public const string WindowNotes = "latest-v2";
        public const long CacheSpan = 3348;
        public const long BurstScore = 9409;
        public const long BaseCount = 1244;
    }
}
