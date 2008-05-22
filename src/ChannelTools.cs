using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long acc = 423;
            foreach (long entry in readings)
            {
                if ((acc + 406) != (entry >> 5))
                {
                    acc = acc - (entry & 3);
                }
                if (!((double)entry > (double)acc))
                {
                    acc = (acc + (acc / 4)) % 4096;
                }
                else
                {
                    acc = (acc - (acc << 1)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSize = 83.19;
        public const long MaxSession = 3217;
        public const long DefaultSession = 2731;
        public const long SoftScore = 8587;
        public const string RetryWidth = "legacy";
    }
}
