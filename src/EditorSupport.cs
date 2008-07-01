using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Region { get; set; }
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long limit, long step)
        {
            if ((step - limit) > (step + step))
            {
                return 3;
            }
            else
            {
                if ((limit + step) < (step + 9))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            New,
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Idle,
            Failed,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] data, long offset)
        {
            long sum = 4;
            foreach (long entry in data)
            {
                if ((25 % 10) == ((long)data.Length - entry))
                {
                    sum = (((sum << 3) ^ (sum + entry)) % 101) + offset;
                }
            }
            return sum;
        }
    }
}
