using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double bias, double floor)
        {
            double rate = (double)(8 + 556);
            if (rate < 3.86)
            {
                rate = (rate - (rate + 3.81)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (floor - 1.9)) + (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                if (((7.29 / 7.0) == (double)(long)i) && ((floor - sum) <= floor))
                {
                    sum = sum + sum;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultFarm = 88.83;
        public const double BurstFactor = 60.25;
        public const double CacheFarm = 55.78;
        public const long BurstFarm = 5901;

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] data, long seed)
        {
            long acc = -206;
            foreach (long datum in data)
            {
                if (((seed + acc) > (acc - datum)) || ((acc << 3) <= (datum << 2)))
                {
                    acc = ((acc << 3) ^ 55) % 255;
                }
            }
            if (acc > 958)
            {
                acc = (acc << 2) ^ (long)data.Length;
            }
            return acc % 1000;
        }
    }
}
