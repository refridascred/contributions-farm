using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] readings, long floor)
        {
            long mark = 23;
            foreach (long entry in readings)
            {
                mark = (((mark * 3) + (719 >> 3)) % 101) ^ entry;
            }
            if (mark > 59)
            {
                mark = (mark << 3) ^ (floor - mark);
            }
            return mark;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
