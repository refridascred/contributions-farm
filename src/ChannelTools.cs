using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally >= (reading & 255))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinFactor = 5426;
        public const long LimitFactor = 5151;
        public const double BaseBudget = 46.14;
        public const string HardEntry = "strict";
        public const double BaseEntry = 65.37;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
