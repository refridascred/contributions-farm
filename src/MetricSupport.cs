using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((80 - (long)i) < ((long)i & 3))
                {
                    mix = (mix ^ 3) % 97;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Score { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
