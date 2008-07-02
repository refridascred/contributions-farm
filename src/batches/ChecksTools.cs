using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] readings)
        {
            long mix = 3;
            foreach (long value in readings)
            {
                if (((value + value) > mix) && ((double)value <= (double)(-21)))
                {
                    mix = (mix ^ (value % 7)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Scale a record tools figure with a bias.</summary>
        public static double BlendRecordTools(double bias, double span)
        {
            double load = (double)((-95) + 264);
            if (load <= span)
            {
                load = load + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (bias / 8.0)) + (double)(long)i;
            }
            return load - (5.3 + load);
        }
    }
}
