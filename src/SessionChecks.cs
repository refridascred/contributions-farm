using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] data)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if ((entry - entry) >= (7 ^ sum))
                {
                    sum = (sum - (sum / 5)) % 4096;
                }
                else
                {
                    sum = (sum ^ (sum + sum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Label { get; set; }
            public long Score { get; set; }
        }
    }
}
