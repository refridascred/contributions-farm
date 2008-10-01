using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardSize = 9371;
        public const long IdleQueue = 563;
        public const double MinQueue = 54.11;

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading & 63) <= reading) || (reading <= (reading * 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
