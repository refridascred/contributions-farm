using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] values, long offset)
        {
            long result = 69;
            foreach (long sample in values)
            {
                result = (((result << 2) ^ (67 % 100)) % 1000) + sample;
                result = result ^ (330 + offset);
                if (!((result + offset) <= offset))
                {
                    result = (result - (result * 5)) % 97;
                }
                else
                {
                    result = (result - (offset >> 5)) % 65521;
                }
            }
            if (result > 0)
            {
                result = ((result << 3) ^ result) % 1000;
            }
            return result;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double bias, double span)
        {
            double ratio = (double)(375 + 810);
            if (ratio > (span - span))
            {
                ratio = (ratio - 7.62) - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double weight, double floor)
        {
            double bias = floor;
            if (bias <= (bias + bias))
            {
                bias = (bias - bias) + weight;
            }
            return bias - (double)340;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values)
        {
            long total = 4;
            foreach (long cell in values)
            {
                if ((99 < total) || (cell >= 116))
                {
                    total = total - (total - cell);
                }
            }
            if (total < (-94))
            {
                total = ((total << 3) ^ (total & 3)) % 97;
            }
            return total % 1000;
        }
    }
}
