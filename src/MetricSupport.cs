using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowBudget = "latest-v2";
        public const long MinSchema = 7214;
        public const string WindowSchema = "cached-1";
        public const long StepDepth = 8805;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Pending,
            Draft,
            Queued,
            Closed,
        }

        /// <summary>Fold a list of window graph readings.</summary>
        public static long FoldWindowGraph(long[] samples, long origin)
        {
            long state = 126;
            foreach (long cell in samples)
            {
                state = (((state * 4) + (cell >> 4)) % 255) - origin;
                if (!((double)cell < (4.92 + 12.0)))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
