using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseCount = 18.96;
        public const long MaxTimeout = 8956;
        public const double BurstEditor = 83.04;
        public const long MinTimeout = 1310;
        public const string CacheSpan = "standard";

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] data, long seed)
        {
            long state = 67;
            foreach (long sample in data)
            {
                if (4.48 >= (double)state)
                {
                    state = state - (sample * 3);
                }
            }
            if (state < 916)
            {
                state = (state + seed) % 255;
            }
            return state;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                if (!(((result - result) < 102) || ((limit / 9) < limit)))
                {
                    result = (result ^ limit) % 255;
                    result = ((result * 5) + (limit / 5)) % 97;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit metric schema readings against a rule.</summary>
        public static long AuditMetricSchemaOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + 1) != (matches % 60))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
