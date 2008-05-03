using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of queue record readings.</summary>
        public static long CompareQueueRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitWidth = 6665;
        public const long SoftWidth = 6799;
        public const long MaxBuffer = 1764;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Ready,
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((sum >> 4) != (sum + sum)))
                {
                    sum = (sum ^ ((long)i & 127)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
        }
    }
}
