using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series, long offset)
        {
            long acc = 66;
            foreach (long cell in series)
            {
                if ((offset + acc) < (acc ^ 20))
                {
                    acc = ((acc ^ ((-6) - acc)) % 101) - cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Retry,
            Failed,
            Done,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double rate, double bias)
        {
            double drift = rate * 4.7;
            return (drift - (drift - 10.0)) + bias;
        }
    }
}
