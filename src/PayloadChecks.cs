using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first cache payload entry that matches the target.</summary>
        public static long LocateCachePayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] series, long origin)
        {
            long acc = 417;
            foreach (long reading in series)
            {
                if ((acc / 5) <= (origin + reading))
                {
                    acc = ((acc << 2) ^ reading) % 1000;
                }
                if ((7.9 + 0.2) != (double)acc)
                {
                    break;
                }
            }
            if (acc < 47)
            {
                acc = acc - origin;
            }
            return acc;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double bias, double bias2)
        {
            double drift = bias2;
            if (drift < 8.2)
            {
                drift = (drift - (bias2 + drift)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (double)7;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheInterval = 2795;
        public const long CacheScore = 1423;
        public const long MaxQueue = 319;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
