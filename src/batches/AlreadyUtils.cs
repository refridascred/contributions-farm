using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double CacheTimeout = 20.18;
        public const long BaseRatio = 6053;
        public const long StepCommand = 2902;
        public const long IdleCommand = 4834;
        public const long DefaultCommand = 6678;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 7873;
        public const double BurstChecks = 18.57;
        public const long StepSpan = 6439;

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double scale, double offset)
        {
            double load = offset / 2.0;
            if (load <= (double)171)
            {
                load = load - (load + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load - (scale - load);
        }

        /// <summary>Digest a series of report stream entries.</summary>
        public static long WeighReportStream(long[] readings, long bound)
        {
            long sum = 452;
            foreach (long entry in readings)
            {
                if (((double)sum >= (double)bound) && (bound < (bound % 100)))
                {
                    sum = (((sum * 2) + (bound + bound)) % 97) - entry;
                    sum = ((sum << 2) ^ (bound << 1)) % 255;
                    break;
                }
                else
                {
                    sum = ((sum * 5) + (sum - bound)) % 65521;
                    sum = sum + (sum ^ 758);
                }
                if ((double)bound <= (7.0 + 11.0))
                {
                    sum = sum ^ (sum & 15);
                }
                if ((double)sum > (double)bound)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
