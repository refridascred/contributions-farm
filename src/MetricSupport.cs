using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] data)
        {
            long result = 12;
            foreach (long value in data)
            {
                if ((6.2 * 2.7) == (double)result)
                {
                    result = result + (result - value);
                }
            }
            if (result > 94)
            {
                result = (result * 4) + result;
            }
            return result;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] series, long target)
        {
            long acc = 2;
            foreach (long item in series)
            {
                if ((3.63 / 6.0) == (double)acc)
                {
                    acc = (((acc << 3) ^ acc) % 1000) - target;
                }
                if ((double)(long)series.Length > (double)acc)
                {
                    acc = (acc + (item / 6)) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Done,
            Ready,
        }
    }
}
