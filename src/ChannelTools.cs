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

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public bool Owner { get; set; }
            public bool Flag { get; set; }
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
