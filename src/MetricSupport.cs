using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Done,
            Failed,
            New,
            Synced,
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

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
