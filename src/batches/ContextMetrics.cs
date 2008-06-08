using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long IdleSize = 3012;
        public const long RetryRoute = 5903;
        public const long MinRoute = 5393;

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 1.48;
        public const double DefaultProfile = 89.27;
        public const long IdleSpan = 4052;
        public const double WindowSpan = 25.65;

        /// <summary>Match up notes editor samples.</summary>
        public static long PairNotesEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of account support readings.</summary>
        public static long PairAccountSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
