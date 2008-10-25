using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            New,
            Queued,
            Pending,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double weight, double offset)
        {
            double rate = offset;
            if (rate <= (offset / 7.0))
            {
                rate = rate - (weight - weight);
            }
            else
            {
                rate = rate - (offset - offset);
            }
            return rate - (offset * 4.78);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 9921;
        public const long BaseCluster = 6248;
        public const string SoftCluster = "legacy-v2";
        public const double MinCluster = 30.29;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
