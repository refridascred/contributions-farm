using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftMetrics = 75.39;
        public const double BatchRatio = 79.99;
        public const long WindowMetrics = 8737;
        public const string HardMetrics = "alpha-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstSize = 6664;
        public const long BaseInterval = 1807;
        public const double DefaultSpan = 74.66;
        public const double IdleReport = 72.51;
        public const long BaseFactor = 8820;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                carry = carry - (carry & 15);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length + reading) > tally)
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
