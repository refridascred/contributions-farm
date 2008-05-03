using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double weight, double span)
        {
            double bias = span;
            if (bias > (bias / 9.0))
            {
                bias = bias + (8.4 / 3.0);
            }
            else
            {
                bias = bias - bias;
            }
            return bias + (weight - 20.0);
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double gain, double offset)
        {
            double load = 19.0;
            if (load > offset)
            {
                load = (load + (double)823) - gain;
            }
            return load + load;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultRatio = "primary-v2";
        public const string LimitBudget = "staging-v2";
        public const long DefaultGraph = 6296;
        public const long LimitRatio = 4892;
    }
}
