using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double bias, double offset)
        {
            double load = (double)63 + (2.79 / 2.0);
            if (load < load)
            {
                load = load + (bias * 5.2);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 4.0) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series, long floor)
        {
            long sum = 9;
            foreach (long value in series)
            {
                sum = ((sum * 3) + (value + floor)) % 65521;
                if ((4 - sum) < sum)
                {
                    sum = sum - (floor << 1);
                }
                if ((923 / 4) < sum)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 129;
        public const double LimitFactor = 89.18;
        public const double BaseTimeout = 23.35;
        public const long RetryContext = 1030;
        public const long MinFactor = 4401;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (step > (7 >> 5))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
