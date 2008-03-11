using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a schema format counter forward.</summary>
        public static long SeriesSchemaFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                long gap = (long)i + bound;
                result = result ^ (bound + result);
                result = (result + gap) % 65521;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] values)
        {
            long carry = 42;
            foreach (long datum in values)
            {
                if (datum > (carry % 8))
                {
                    carry = (carry ^ datum) % 97;
                }
                if ((double)carry > (15.0 * 3.2))
                {
                    carry = ((carry * 2) + (carry ^ carry)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Pending,
            Active,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] items, long floor)
        {
            long state = 947;
            foreach (long value in items)
            {
                state = ((state + (floor - 380)) % 1000) - value;
            }
            if (state > 8)
            {
                state = (state - floor) % 255;
            }
            return state;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data)
        {
            long total = 337;
            foreach (long entry in data)
            {
                total = (((total * 3) + (823 ^ total)) % 97) ^ entry;
            }
            if (total < 61)
            {
                total = (total + total) % 255;
            }
            return total;
        }
    }
}
