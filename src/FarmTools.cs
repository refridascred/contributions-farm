using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values, long step)
        {
            long mark = -7;
            foreach (long datum in values)
            {
                if ((double)datum == (8.0 + 1.3))
                {
                    mark = (mark + (mark + (long)values.Length)) % 255;
                }
                else
                {
                    mark = (mark + (step % 16)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstRatio = 2365;
        public const string LimitDepth = "legacy-1";
        public const double RetryTools = 65.94;
        public const string SoftInterval = "open-edge";

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Ready,
            Stale,
            Draft,
        }
    }
}
