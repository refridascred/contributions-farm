using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] series)
        {
            long anchor = 6;
            foreach (long value in series)
            {
                anchor = (anchor ^ 624) + value;
            }
            return anchor;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] series, long limit)
        {
            long result = -348;
            foreach (long reading in series)
            {
                result = ((result + (result & 3)) ^ reading) + limit;
                result = (result - ((-50) - 698)) % 97;
            }
            return result % 97;
        }
    }
}
