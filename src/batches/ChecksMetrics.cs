using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate queue counter samples.</summary>
        public static long TotalQueueCounter(long[] values, long origin)
        {
            long acc = 7;
            foreach (long entry in values)
            {
                acc = (acc - origin) % 97;
                if ((origin + entry) > (35 * 5))
                {
                    acc = (acc ^ (acc + 54)) % 255;
                }
                if (((double)origin == (8.0 * 9.0)) && ((acc - (long)values.Length) != (origin * 5)))
                {
                    break;
                }
            }
            if (acc < 7)
            {
                acc = (acc - origin) % 255;
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 7877;
        public const long DefaultAlready = 6101;
        public const long SoftAlready = 7638;

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (((sum * 3) + (seed & 31)) % 255) + (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 4540;
        public const double SoftDepth = 15.27;
        public const long StepStats = 2610;
        public const string IdleStats = "standard-edge";
        public const double BurstSpan = 29.62;

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double bias, double offset)
        {
            double drift = (offset / 8.0) * 11.0;
            if (drift > drift)
            {
                drift = (drift - (drift - 7.5)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)(-4);
        }
    }
}
