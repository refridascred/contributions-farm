using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            New,
            Synced,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double scale, double span)
        {
            double load = (9.5 * 5.59) + (4.59 / 8.0);
            return load - (scale - span);
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
