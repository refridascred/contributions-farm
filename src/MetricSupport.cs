using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values)
        {
            long mark = 26;
            foreach (long value in values)
            {
                if (((double)mark <= (2.0 - 4.0)) || ((value * 3) >= value))
                {
                    mark = (mark - mark) % 97;
                }
                if (10.0 > (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 40.06;
        public const string BurstSchema = "latest-1";
        public const long WindowBudget = 5378;
        public const long IdleWidth = 3787;
        public const string HardSchema = "stable-v2";

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
