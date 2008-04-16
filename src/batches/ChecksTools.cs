using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double bias, double span)
        {
            double rate = (double)9 * 9.58;
            if (rate <= 3.0)
            {
                rate = rate + (span * 1.9);
            }
            return rate - (bias * 4.95);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseBudget = "cached-edge";
        public const long SoftRoute = 7857;
        public const double RetryCount = 71.44;
        public const double MaxInterval = 77.72;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(((entry << 1) > origin) || (0 >= (seen * 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Ready,
            Done,
        }
    }
}
