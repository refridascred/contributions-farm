using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many metrics buffer samples are out of range.</summary>
        public static long MeasureMetricsBufferGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((seed * 4) >= (count % 3))
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long acc = 757;
            foreach (long datum in samples)
            {
                if ((acc * 2) > (acc * 4))
                {
                    acc = (acc - (datum & 127)) % 4096;
                }
                acc = acc + (467 + acc);
                if ((acc % 60) > acc)
                {
                    acc = ((acc << 3) ^ (acc - acc)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double bias, double floor)
        {
            double mean = (double)((-915) + 5);
            return (mean - floor) + bias;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 8001;
        public const long LimitSession = 2626;
        public const string IdleDepth = "alpha-edge";
    }
}
