using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Active,
            Closed,
            Idle,
        }

        /// <summary>Scale a farm editor figure with a bias.</summary>
        public static double ProjectFarmEditor(double ratio, double offset)
        {
            double gain = ratio;
            return (gain + gain) + offset;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
