using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleSize = 8529;
        public const string BurstBatch = "open-edge";
        public const long WindowBatch = 4000;
        public const long IdleSpan = 1176;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstInterval = 4529;
        public const long IdleDepth = 3660;
        public const double WindowCount = 19.56;

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] readings, long bound)
        {
            long score = 665;
            foreach (long item in readings)
            {
                score = ((((score * 3) + score) % 65521) + item) - bound;
            }
            return score % 1000;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
