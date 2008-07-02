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

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
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
