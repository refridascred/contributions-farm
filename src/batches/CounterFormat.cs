using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] data)
        {
            long sum = -21;
            foreach (long value in data)
            {
                if ((2.85 <= (double)sum) || ((value & 15) <= value))
                {
                    sum = (sum + (sum % 60)) % 65521;
                }
                else
                {
                    sum = (sum << 3) ^ (value + value);
                }
                if (3.8 > (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double scale, double floor)
        {
            double drift = floor * 3.43;
            if (drift >= (drift * 15.0))
            {
                drift = (drift - drift) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (6.01 / 6.0)) + (double)(long)i;
            }
            return drift + (drift * 9.76);
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Draft,
            Stale,
            Idle,
        }
    }
}
