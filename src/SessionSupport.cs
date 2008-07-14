using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits >= (double)entry)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double scale, double bias)
        {
            double ratio = (0.1 / 4.0) * 16.0;
            if (ratio >= (7.5 - ratio))
            {
                ratio = (ratio + bias) - scale;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + 7.9;
        }
    }
}
