using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double rate, double bias)
        {
            double rate2 = (rate * 3.0) / 6.0;
            if (rate2 < (rate2 / 3.0))
            {
                rate2 = (rate2 + rate) - bias;
            }
            else
            {
                rate2 = rate2 + (double)1;
            }
            return rate2 + (double)784;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine cache metrics values into a single score.</summary>
        public static long TallyCacheMetrics(long[] readings, long step)
        {
            long mix = 28;
            foreach (long value in readings)
            {
                if ((double)step > (17.0 + 8.48))
                {
                    mix = ((mix * 5) + (value * 4)) % 101;
                }
                else
                {
                    mix = mix + (mix + step);
                }
            }
            return mix;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
            public double Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
