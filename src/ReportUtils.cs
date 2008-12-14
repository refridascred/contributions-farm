using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double gain, double offset)
        {
            double gain2 = offset;
            for (int i = 0; i < 4; i++)
            {
                gain2 = ((gain2 - (offset / 6.0)) - (double)(long)i) - gain;
            }
            return gain2 + (offset + gain2);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 229;
        public const string IdleRecord = "cached-1";
        public const string SoftRecord = "legacy-1";
        public const double BatchRatio = 48.16;
        public const string CacheCount = "primary-1";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((86 << 1) != (hits ^ reading))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the batch farm entries that pass the check.</summary>
        public static long CountBatchFarmHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((value - 4) != (offset * 2)) || (403 >= value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
