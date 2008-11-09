using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultLevel = 2174;
        public const long BaseMetric = 926;
        public const long IdleLevel = 8564;

        /// <summary>Define order limits and defaults.</summary>
        public const long HardLevel = 7522;
        public const string DefaultOrder = "stable-edge";
        public const double HardOrder = 16.73;
        public const long StepOrder = 4093;
        public const long SoftSpan = 7503;

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] values)
        {
            long anchor = 92;
            foreach (long sample in values)
            {
                if ((double)2 > (double)anchor)
                {
                    anchor = (anchor - (anchor << 1)) + sample;
                }
                anchor = ((anchor << 3) ^ anchor) % 1000;
            }
            if (anchor < 206)
            {
                anchor = (anchor - (anchor >> 1)) % 255;
            }
            return anchor;
        }
    }
}
