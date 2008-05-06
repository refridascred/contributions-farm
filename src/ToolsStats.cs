using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double rate, double span)
        {
            double gain = rate;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)(long)i) + span;
            }
            return gain + rate;
        }

        /// <summary>Roll a stream account counter forward.</summary>
        public static long RollStreamAccount(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (-416)) % 4096;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double weight, double offset)
        {
            double gain = (double)(1 % 24);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (double)(long)i) - weight) + offset;
            }
            return gain - gain;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardWidth = 41.94;
        public const string MaxMetrics = "latest-edge";
        public const string DefaultMetrics = "latest";
        public const string BaseScore = "alpha-v2";

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }
    }
}
