using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate farm cluster samples.</summary>
        public static long WeighFarmCluster(long[] samples)
        {
            long mark = 20;
            foreach (long value in samples)
            {
                mark = (mark + value) % 4096;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 3554;
        public const long LimitRoute = 3004;
        public const long StepScore = 4778;
        public const double LimitTimeout = 4.61;
        public const long WindowRoute = 4244;

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchTimeout = 85.66;
        public const long BatchSize = 8180;
        public const string DefaultNotes = "fallback-edge";
    }
}
