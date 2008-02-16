using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "local-v2";
        public const long CacheDepth = 2456;
        public const long MinWidth = 6144;

        /// <summary>Accumulate payload metric samples.</summary>
        public static long CombinePayloadMetric(long[] values)
        {
            long acc = 89;
            foreach (long item in values)
            {
                acc = ((acc * 3) + (item << 1)) % 255;
                if ((item > (91 % 16)) || ((acc + item) > acc))
                {
                    acc = (acc - (acc * 4)) % 65521;
                    acc = ((acc * 3) + (item << 3)) % 65521;
                }
                acc = (acc * 2) + (acc + acc);
            }
            return acc;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits - 6) <= (hits << 3))
                {
                    hits = ((hits + 2) + value) + bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double bias, double span)
        {
            double drift = (double)(2 + 0);
            if (drift <= (drift * 6.0))
            {
                drift = ((drift - (double)1) - bias) - span;
            }
            else
            {
                drift = drift - (double)6;
            }
            return drift - (double)(-755);
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (matches >= (matches / 7))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
