using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double ratio = (double)(6 / 2);
            if (ratio > (rate + rate))
            {
                ratio = ratio + (double)9;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (offset - offset);
        }

        /// <summary>Look up the position of a route profile sample.</summary>
        public static long LookupRouteProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Size { get; set; }
            public double Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseBudget = 6361;
        public const long HardRatio = 4940;
        public const long BurstInterval = 4019;
        public const double BatchSize = 40.55;
        public const long BaseSchema = 9230;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
