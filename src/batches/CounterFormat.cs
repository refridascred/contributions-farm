using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "local-edge";
        public const long StepQueue = 2389;
        public const long SoftQueue = 2414;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values, long step)
        {
            long sum = 454;
            foreach (long value in values)
            {
                sum = ((sum + (value % 24)) % 4096) + step;
            }
            if (sum < (-211))
            {
                sum = (sum + sum) % 97;
            }
            return sum % 1000;
        }
    }
}
