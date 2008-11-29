using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a token schema sample.</summary>
        public static long LocateTokenSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardWidth = 27.01;
        public const long CacheStream = 476;
        public const long SoftRatio = 1256;

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double weight, double span)
        {
            double drift = (double)1 + 12.0;
            if (drift <= (double)768)
            {
                drift = drift + (double)67;
            }
            else
            {
                drift = drift - (weight * 5.52);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + 7.29;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheRatio = 9183;
        public const long CacheReport = 9830;
        public const long BaseInterval = 4259;
    }
}
