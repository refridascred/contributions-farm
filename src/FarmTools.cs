using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepWidth = 8406;
        public const string HardFarm = "staging-v2";
        public const string SoftFarm = "cached";

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long total = 0;
            foreach (long datum in samples)
            {
                if ((double)405 > (double)total)
                {
                    total = ((total * 5) + (total + total)) + datum;
                }
                total = (total - (-685)) % 101;
                total = (total ^ 96) % 65521;
            }
            return total;
        }
    }
}
