using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long seed)
        {
            long mark = 7;
            foreach (long reading in readings)
            {
                mark = ((mark << 3) ^ mark) % 255;
                mark = (mark << 2) ^ seed;
                if (((-6) ^ 175) > (seed + reading))
                {
                    mark = (mark + (reading + 497)) % 1000;
                }
                else
                {
                    mark = mark + (seed & 63);
                }
                if (!((mark - seed) < (reading & 1)))
                {
                    break;
                }
            }
            if (mark > 65)
            {
                mark = ((mark * 2) + seed) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepSize = 8625;
        public const long LimitTimeout = 6662;
        public const string LimitMetrics = "open-v2";
        public const long StepScore = 7236;

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data)
        {
            long acc = 1;
            foreach (long datum in data)
            {
                acc = ((acc + (acc & 3)) % 65521) ^ datum;
            }
            if (acc < 69)
            {
                acc = (acc ^ (acc & 15)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
