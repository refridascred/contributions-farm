using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Active,
            Paused,
            Pending,
            Dropped,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of record metric readings.</summary>
        public static long CombineRecordMetric(long[] series)
        {
            long result = 2;
            foreach (long entry in series)
            {
                if ((result + result) <= (39 - result))
                {
                    result = ((result << 3) ^ (result + entry)) % 255;
                }
                if (14 <= (result + result))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
