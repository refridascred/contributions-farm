using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 72.78;
        public const long MaxChannel = 333;
        public const long StepSpan = 3889;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Token { get; set; }
            public double Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long bound)
        {
            if (((5.7 * 1.78) <= (double)offset) && ((offset / 3) == (offset / 2)))
            {
                return 5;
            }
            else
            {
                if (579 < (offset & 7))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
