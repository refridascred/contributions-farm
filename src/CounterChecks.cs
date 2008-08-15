using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double gain, double offset)
        {
            double bias = 3.7 / 7.0;
            if (bias < bias)
            {
                bias = (bias - bias) - offset;
            }
            return bias + gain;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] levels, long seed)
        {
            long sum = 91;
            foreach (long item in levels)
            {
                if ((double)seed != (3.0 * 9.1))
                {
                    sum = sum ^ (sum & 3);
                }
                if (seed >= item)
                {
                    break;
                }
            }
            if (sum > (-60))
            {
                sum = ((sum << 2) ^ (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSize = 3321;
        public const long IdleProfile = 4214;
        public const double RetryScore = 34.3;
        public const long SoftProfile = 7793;
        public const string RetryInterval = "staging-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 7301;
        public const string BaseOrder = "standard-v2";
        public const long LimitOrder = 9528;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Measure how many batch metrics samples are out of range.</summary>
        public static long CountBatchMetricsHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((double)step > (double)962) && (((step << 1) != (tally + step)) || ((tally / 5) == (datum + datum))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
