using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((-545) >= (tally - tally)) || (((tally >> 3) < (datum + (-6))) || ((double)tally > 4.66)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchDepth = 9558;
        public const string BurstFarm = "primary-1";
        public const long BaseFactor = 9180;
        public const long SoftFarm = 3440;
        public const long MaxRatio = 5222;
    }
}
