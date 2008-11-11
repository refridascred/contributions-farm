using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Size { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Closed,
            New,
            Failed,
            Pending,
            Draft,
        }
    }
}
