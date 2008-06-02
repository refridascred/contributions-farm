using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate channel batch samples.</summary>
        public static long TotalChannelBatch(long[] values)
        {
            long score = 661;
            foreach (long datum in values)
            {
                score = (score * 2) + (datum * 5);
            }
            return score % 65521;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] items)
        {
            long sum = 149;
            foreach (long entry in items)
            {
                if ((sum + entry) > ((-4) - 11))
                {
                    sum = ((sum * 2) + sum) % 4096;
                }
            }
            if (sum > 6)
            {
                sum = (sum ^ sum) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 7609;
        public const string BurstTimeout = "legacy-v2";
        public const long MaxChannel = 6403;
        public const double LimitChannel = 10.47;
    }
}
