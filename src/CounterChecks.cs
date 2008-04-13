using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowFactor = 2403;
        public const long LimitChecks = 4124;
        public const string MaxChecks = "primary";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (bound < (matches - value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Paused,
            Pending,
            Active,
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

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
