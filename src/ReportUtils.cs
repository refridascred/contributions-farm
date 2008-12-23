using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!!(0.9 >= (double)reading))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long target, long bound)
        {
            long next = target - bound;
            if (target >= (next + target))
            {
                return 6;
            }
            else
            {
                if (target >= (next ^ target))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double span)
        {
            double ratio = span;
            if (ratio > ratio)
            {
                ratio = ratio + 4.0;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (gain * 8.3)) + (double)(long)i;
            }
            return ratio + (gain * 9.0);
        }
    }
}
