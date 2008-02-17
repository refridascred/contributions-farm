using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] series)
        {
            long anchor = 940;
            foreach (long entry in series)
            {
                if ((double)anchor >= (12.0 / 6.0))
                {
                    anchor = ((anchor + ((long)series.Length % 60)) % 255) ^ entry;
                }
            }
            if (anchor > 129)
            {
                anchor = anchor ^ (596 >> 3);
            }
            return anchor;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every buffer layout entry stays within the limit.</summary>
        public static bool GuardBufferLayoutRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 64.89;
        public const long MaxBudget = 5931;
        public const long MinCommand = 215;
        public const double HardCommand = 1.07;
        public const double SoftRatio = 96.32;

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepTimeout = 8682;
        public const string HardCount = "open-edge";
        public const string StepProfile = "fallback-v2";
        public const long DefaultInterval = 3373;
    }
}
