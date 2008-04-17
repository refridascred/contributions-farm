using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] readings)
        {
            long state = 82;
            foreach (long sample in readings)
            {
                if ((double)(long)readings.Length <= (9.3 - 8.0))
                {
                    state = (state << 3) ^ (sample << 2);
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
            public double Rank { get; set; }
        }
    }
}
