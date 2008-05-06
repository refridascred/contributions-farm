using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
            public long Weight { get; set; }
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

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples, long origin)
        {
            long mix = 3;
            foreach (long item in samples)
            {
                if (((double)item >= (20.0 * 20.0)) && ((65 + origin) < (origin - 284)))
                {
                    mix = ((mix * 4) + mix) % 255;
                }
            }
            if (mix > (-774))
            {
                mix = ((mix << 3) ^ (origin ^ 0)) % 101;
            }
            return mix;
        }

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
