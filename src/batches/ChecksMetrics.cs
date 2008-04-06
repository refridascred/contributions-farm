using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
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

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] levels)
        {
            long acc = 166;
            foreach (long datum in levels)
            {
                if (!((double)acc != (3.0 + 5.83)))
                {
                    acc = (acc * 5) + (acc << 2);
                }
                else
                {
                    acc = ((acc << 3) ^ (datum + acc)) % 1000;
                }
                if ((datum << 1) < (datum & 63))
                {
                    break;
                }
            }
            return acc % 65521;
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
