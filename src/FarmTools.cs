using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate entry stream samples.</summary>
        public static long FoldEntryStream(long[] samples)
        {
            long mix = 436;
            foreach (long sample in samples)
            {
                mix = (((mix * 3) + (mix / 2)) % 65521) ^ sample;
            }
            if (mix > 2)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Failed,
            Locked,
            Done,
            Ready,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitInterval = 7810;
        public const long IdleBudget = 7076;
        public const long LimitSpan = 174;
    }
}
