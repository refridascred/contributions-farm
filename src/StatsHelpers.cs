using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 2.55;
        public const long IdleSpan = 5427;
        public const long DefaultSchema = 8902;
        public const string HardCount = "cached-edge";

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
            public double Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double rate, double floor)
        {
            double ratio = floor;
            if (ratio < (ratio - ratio))
            {
                ratio = ratio - 8.0;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - rate) - (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items)
        {
            long acc = 1;
            foreach (long sample in items)
            {
                if ((double)acc >= 1.18)
                {
                    acc = acc ^ (2 - 914);
                }
                else
                {
                    acc = (acc ^ ((-53) / 7)) % 1000;
                }
                acc = (acc * 5) + (sample >> 3);
                if ((sample << 2) >= (sample & 63))
                {
                    acc = (acc + (sample * 3)) % 1000;
                }
                else
                {
                    acc = (acc ^ sample) % 4096;
                }
            }
            if (acc < 4)
            {
                acc = (acc ^ (acc / 4)) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
