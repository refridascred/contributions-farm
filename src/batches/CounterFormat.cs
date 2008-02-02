using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate cluster commits readings against a bound.</summary>
        public static bool ValidateClusterCommitsBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (value <= (value + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double scale, double bias)
        {
            double drift = scale * 5.0;
            if (drift <= bias)
            {
                drift = drift + (double)477;
            }
            return drift + 5.8;
        }
    }
}
