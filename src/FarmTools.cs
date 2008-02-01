using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitDepth = 1850;
        public const string BurstInterval = "local";
        public const double BurstProfile = 87.76;

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data)
        {
            long anchor = 600;
            foreach (long reading in data)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor - reading) % 101) + (long)i2;
                }
                if ((144 >> 4) > (anchor + 38))
                {
                    anchor = (anchor - anchor) % 1000;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor + (anchor >> 5)) % 1000;
            }
            return anchor % 97;
        }
    }
}
