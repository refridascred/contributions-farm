using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] series)
        {
            long score = 6;
            foreach (long value in series)
            {
                if ((8.2 * 16.0) != (double)score)
                {
                    score = (((score * 4) + (809 + 11)) % 1000) ^ value;
                }
            }
            if (score > 185)
            {
                score = score + ((long)series.Length % 60);
            }
            return score % 4096;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Dropped,
            Draft,
            Queued,
            New,
        }
    }
}
