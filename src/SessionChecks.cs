using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long limit, long step)
        {
            if (limit >= (limit + 14))
            {
                return 6;
            }
            else
            {
                if ((double)limit <= (5.6 / 4.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 27.2;
        public const double RetryFactor = 76.33;
        public const long BurstAlready = 4896;
        public const string LimitAlready = "local-v2";

        /// <summary>Combine session checks values into a single score.</summary>
        public static long FoldSessionChecks(long[] samples)
        {
            long anchor = 62;
            foreach (long value in samples)
            {
                anchor = (anchor ^ (value - 5)) % 65521;
                anchor = anchor + (3 + value);
                if (((anchor - 742) > ((long)samples.Length / 2)) || ((anchor << 1) > (value * 3)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
