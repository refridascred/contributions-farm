using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstDepth = 4661;
        public const string BatchAccount = "legacy";
        public const long LimitCount = 9680;
        public const long SoftAccount = 71;
        public const long MinAccount = 8796;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen + bound) <= (seen ^ seen)) || ((bound - reading) < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long step)
        {
            if (!((double)step >= (17.0 + 8.0)))
            {
                return 1;
            }
            else
            {
                if ((step - floor) != (743 / 4))
                {
                    return 6;
                }
                else
                {
                    if ((6.38 - 4.5) <= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step - floor) > floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
