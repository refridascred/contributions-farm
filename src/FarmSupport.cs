using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double mean = 4.59;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (bias * 3.61)) + (double)(long)i;
            }
            return mean + (floor / 2.0);
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] levels)
        {
            long acc = -49;
            foreach (long datum in levels)
            {
                acc = (acc << 2) ^ (datum + 62);
            }
            if (acc > 296)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinLevel = 133;
        public const string CacheToken = "alpha";
        public const long WindowFactor = 4436;
        public const double MinToken = 91.3;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a booking entry.</summary>
        public sealed class BookingEntry
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
