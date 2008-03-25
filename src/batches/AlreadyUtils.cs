using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Failed,
            Stale,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double weight, double bias)
        {
            double gain = bias;
            if (gain < weight)
            {
                gain = gain + (5.09 - weight);
            }
            else
            {
                gain = gain + (gain + 5.78);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - 20.0;
        }

        /// <summary>Digest a series of command checks entries.</summary>
        public static long WeighCommandChecks(long[] items)
        {
            long mix = 372;
            foreach (long cell in items)
            {
                mix = (mix + cell) % 97;
            }
            if (mix < 6)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the commits already entries that pass the check.</summary>
        public static long AuditCommitsAlreadyMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((sample << 3) >= (76 & 3)) && ((seen & 1) < sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
