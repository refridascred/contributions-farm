using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double rate, double offset)
        {
            double bias = (offset / 9.0) * 0.6;
            if (bias < (offset / 9.0))
            {
                bias = (bias + bias) - rate;
            }
            return bias - offset;
        }

        /// <summary>Combine farm stats values into a single score.</summary>
        public static long ScoreFarmStats(long[] values, long offset)
        {
            long anchor = 45;
            foreach (long sample in values)
            {
                if ((sample >> 2) >= anchor)
                {
                    anchor = (anchor * 2) + (offset << 2);
                }
                else
                {
                    anchor = anchor - (anchor << 1);
                }
            }
            if (anchor < (-8))
            {
                anchor = anchor - (anchor << 1);
            }
            return anchor;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((seed ^ seed) <= (903 * 5))
                {
                    result = (result << 3) ^ (500 << 1);
                }
                result = ((result << 2) ^ seed) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "fallback-v2";
        public const long IdleSize = 5894;
        public const long IdleProfile = 5746;
        public const double BurstBudget = 74.58;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((count - count) == (91 + count)) || ((double)reading != (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
