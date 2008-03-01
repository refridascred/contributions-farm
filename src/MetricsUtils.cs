using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double ratio, double floor)
        {
            double drift = floor;
            if (drift >= (double)26)
            {
                drift = drift + (double)5;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - floor) - (double)(long)i;
            }
            return drift - (ratio - 9.9);
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route stream measurements.</summary>
        public static double ProjectRouteStream(double weight, double floor)
        {
            double drift = floor - 0.16;
            return drift - weight;
        }

        /// <summary>Derive the next farm counter value from a seed.</summary>
        public static long StepFarmCounter(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + (mark << 2)) % 1000;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Pending,
            Ready,
        }
    }
}
