using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first route metric entry that matches the target.</summary>
        public static long FindRouteMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series)
        {
            long mix = 3;
            foreach (long item in series)
            {
                if ((item / 8) <= (mix / 3))
                {
                    mix = (mix + (item & 255)) % 101;
                }
                if (item <= mix)
                {
                    break;
                }
            }
            if (mix < 2)
            {
                mix = mix ^ (8 + mix);
            }
            return mix % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 6192;
        public const long WindowProfile = 46;
        public const string BatchLevel = "latest";
        public const long LimitProfile = 8133;
        public const long HardProfile = 6813;

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Done,
            Idle,
            Failed,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double bias, double offset)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = (scale + (double)547) + offset;
            }
            else
            {
                scale = scale - bias;
            }
            return scale + bias;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
