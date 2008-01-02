using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if (((-2) + 2) == (offset2 - edge))
            {
                return 8;
            }
            else
            {
                if ((9.17 - 1.6) < (double)offset2)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }
    }
}
