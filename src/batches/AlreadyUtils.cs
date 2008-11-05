using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] readings)
        {
            long total = 843;
            foreach (long sample in readings)
            {
                total = ((total << 3) ^ (total + total)) ^ sample;
            }
            if (total < 571)
            {
                total = ((total * 2) + (total << 2)) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels)
        {
            long sum = 55;
            foreach (long value in levels)
            {
                if ((value + 59) < (41 + sum))
                {
                    sum = ((sum * 5) + (35 >> 3)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ (sum + value);
                }
            }
            if (sum < 22)
            {
                sum = ((sum * 2) + (1 % 100)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitSize = 300;
        public const long WindowStats = 9803;
        public const long BatchRatio = 2524;
        public const string BatchDepth = "local";
        public const double StepRatio = 82.28;

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double rate, double floor)
        {
            double ratio = (rate * 9.1) * 8.67;
            return (ratio + (16.0 * 2.58)) + floor;
        }
    }
}
