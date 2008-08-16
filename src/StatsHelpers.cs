using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] readings, long bound)
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

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "cached";
        public const string MaxCount = "primary-edge";
        public const long DefaultStats = 7316;
        public const double StepTimeout = 33.57;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                if (!(((double)step != (double)(long)i) && (step > (5 >> 5))))
                {
                    acc = acc ^ step;
                    acc = ((acc * 5) + (acc << 3)) % 255;
                }
                if (5.61 < (double)(long)i)
                {
                    acc = ((acc * 3) + acc) % 97;
                    acc = (acc ^ ((long)i ^ (long)i)) % 97;
                    continue;
                }
                acc = ((acc * 5) + ((long)i & 1)) % 255;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 9687;
        public const double BatchAccount = 42.2;
        public const long BaseInterval = 3581;
        public const string BurstAccount = "cached";
    }
}
