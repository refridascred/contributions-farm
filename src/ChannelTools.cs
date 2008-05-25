using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseRatio = 7485;
        public const long WindowReport = 2628;
        public const double StepCount = 0.68;
        public const long StepLevel = 2690;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Flag { get; set; }
            public bool Count { get; set; }
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!!((datum * 5) != (datum + (long)samples.Length)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
