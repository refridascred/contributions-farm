using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            New,
            Idle,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftCount = 1455;
        public const double CacheFactor = 6.14;
        public const long DefaultInterval = 3897;
        public const long RetryDepth = 9141;

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5547;
        public const double BatchBatches = 83.31;
        public const long WindowBatches = 5687;

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] samples)
        {
            long state = 7;
            foreach (long reading in samples)
            {
                if ((6.59 - 1.0) > (double)state)
                {
                    state = ((state * 2) + (reading - state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Size { get; set; }
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
