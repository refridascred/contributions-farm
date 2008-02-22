using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = mark - limit;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Project the next token graph value.</summary>
        public static double AdjustTokenGraph(double ratio, double span)
        {
            double gain = (double)(3 ^ 336);
            if (gain > ratio)
            {
                gain = gain - (double)999;
            }
            else
            {
                gain = gain + ratio;
            }
            return gain - (1.14 - span);
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double weight, double span)
        {
            double rate = (weight - weight) + (span / 7.0);
            if (rate <= weight)
            {
                rate = rate - (weight + weight);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + (weight * 1.0);
        }
    }
}
