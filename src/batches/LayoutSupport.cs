using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every route counter entry stays within the limit.</summary>
        public static bool CheckRouteCounterBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowLevel = 98.59;
        public const long WindowBatch = 8648;
        public const double MaxBatch = 43.44;
        public const double CacheBatch = 67.75;

        /// <summary>Blend two buffer checks measurements.</summary>
        public static double ScaleBufferChecks(double weight, double floor)
        {
            double load = weight - (double)9;
            if (load >= floor)
            {
                load = load - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load * 20.0)) - (double)(long)i;
            }
            return load - (floor / 4.0);
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit token batches readings against a rule.</summary>
        public static long AuditTokenBatchesMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((origin - sample) >= 98)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
