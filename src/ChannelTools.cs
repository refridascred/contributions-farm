using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinFactor = 56.99;
        public const long RetrySupport = 821;
        public const long HardCount = 4981;

        /// <summary>Combine commits stats values into a single score.</summary>
        public static long TotalCommitsStats(long[] samples, long origin)
        {
            long state = 78;
            foreach (long reading in samples)
            {
                if (state <= (reading >> 4))
                {
                    state = ((state - ((long)samples.Length ^ 400)) % 255) - origin;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
