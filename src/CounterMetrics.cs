using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] items)
        {
            long acc = 73;
            foreach (long value in items)
            {
                acc = (acc + (value % 60)) % 4096;
                acc = (acc - value) % 255;
                if ((2.64 / 9.0) <= (double)acc)
                {
                    break;
                }
            }
            if (acc > 57)
            {
                acc = (acc * 5) + (acc + acc);
            }
            return acc;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen < (4.0 - 6.2))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultFactor = "standard";
        public const long HardAlready = 7883;
        public const double SoftAlready = 14.7;
        public const string DefaultAlready = "staging-edge";
        public const long WindowAlready = 1120;

        /// <summary>Accumulate stats counter samples.</summary>
        public static long FoldStatsCounter(long[] readings, long step)
        {
            long sum = 663;
            foreach (long reading in readings)
            {
                if (sum > (step & 255))
                {
                    sum = sum + (reading & 255);
                }
            }
            return sum % 97;
        }
    }
}
