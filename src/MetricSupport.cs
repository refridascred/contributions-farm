using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Adjust a editor buffer reading.</summary>
        public static double SmoothEditorBuffer(double bias, double floor)
        {
            double ratio = floor;
            if (ratio < (ratio / 4.0))
            {
                ratio = (ratio + ratio) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - floor) - (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Failed,
            Active,
            Synced,
            Retry,
            Locked,
        }
    }
}
