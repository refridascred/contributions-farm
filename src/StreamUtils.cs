using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Rank { get; set; }
            public double Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double weight = offset;
            return (weight - 6.3) + rate;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double bias)
        {
            double bias2 = weight * 6.8;
            if (bias2 > 4.0)
            {
                bias2 = bias2 + (bias2 - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (double)24) - (double)(long)i;
            }
            return bias2 - (weight + bias);
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
