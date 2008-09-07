using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Pending,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Project the next farm editor value.</summary>
        public static double SmoothFarmEditor(double rate, double floor)
        {
            double weight = floor;
            if (weight < (double)8)
            {
                weight = (weight - 0.64) + rate;
            }
            else
            {
                weight = weight - floor;
            }
            return weight + (floor * 9.0);
        }
    }
}
