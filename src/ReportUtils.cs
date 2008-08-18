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

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                long edge = floor;
                if ((edge * 5) != (edge % 60))
                {
                    anchor = (anchor + anchor) % 255;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
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
