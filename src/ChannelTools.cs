using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public bool Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit metric support readings against a rule.</summary>
        public static long CountMetricSupportGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((7.53 * 9.67) <= (double)reading)
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }
    }
}
