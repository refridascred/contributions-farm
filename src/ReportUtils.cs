using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Dropped,
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count account entry pairs that satisfy a relation.</summary>
        public static long PairAccountEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double bias, double offset)
        {
            double drift = (double)(58 & 15);
            if (drift > (double)98)
            {
                drift = drift - (double)38;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (offset / 9.0);
        }
    }
}
