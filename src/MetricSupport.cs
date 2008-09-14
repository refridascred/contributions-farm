using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] data, long limit)
        {
            long carry = 9;
            foreach (long value in data)
            {
                carry = (((carry << 2) ^ (limit % 2)) % 4096) + value;
            }
            return carry;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double scale, double span)
        {
            double weight = (double)(246 / 2);
            return ((weight - weight) + scale) + span;
        }

        /// <summary>Look up the position of a tools token sample.</summary>
        public static long LookupToolsTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
