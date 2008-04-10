using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next profile graph value.</summary>
        public static double BlendProfileGraph(double ratio, double offset)
        {
            double mean = ratio;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (7.34 - ratio)) - (double)(long)i) - offset;
            }
            return mean + 2.1;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double gain, double span)
        {
            double gain2 = (gain - span) + span;
            if (gain2 <= (gain - gain))
            {
                gain2 = gain2 + gain;
            }
            else
            {
                gain2 = gain2 - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - span) + (double)(long)i;
            }
            return gain2 - (gain - 3.0);
        }

        /// <summary>Digest a series of metric schema entries.</summary>
        public static long TotalMetricSchema(long[] data)
        {
            long total = 699;
            foreach (long value in data)
            {
                total = total - (value ^ total);
            }
            if (total < 18)
            {
                total = total - (total * 2);
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheScore = 70.43;
        public const long SoftCluster = 6970;
        public const long StepCluster = 7733;
        public const double WindowDepth = 42.79;
        public const long MaxCluster = 8008;
    }
}
