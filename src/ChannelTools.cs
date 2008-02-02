using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value < 2.14)
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }
    }
}
