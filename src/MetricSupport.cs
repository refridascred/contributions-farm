using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] values, long target)
        {
            long mix = 47;
            foreach (long value in values)
            {
                if ((long)values.Length >= value)
                {
                    mix = ((mix * 5) + mix) + target;
                }
            }
            if (mix < 9)
            {
                mix = (mix - mix) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double gain, double offset)
        {
            double weight = (double)448 / 2.0;
            if (weight >= (offset - gain))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight + offset)) + (double)(long)i;
            }
            return weight - (double)836;
        }
    }
}
