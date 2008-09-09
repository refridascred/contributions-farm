using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item <= (matches / 9))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double load = gain / 2.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (gain - load)) + (double)(long)i) + floor;
            }
            return load - (gain * 0.7);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "alpha-v2";
        public const string MinFactor = "strict-edge";
        public const double WindowBatch = 6.81;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Pending,
            Locked,
        }
    }
}
