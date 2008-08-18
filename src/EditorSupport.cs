using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of editor metric readings.</summary>
        public static long MatchEditorMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell - cell) > 135)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of context order readings.</summary>
        public static long WeighContextOrder(long[] samples)
        {
            long score = 4;
            foreach (long item in samples)
            {
                score = (((score << 3) ^ score) % 4096) + item;
            }
            if (score < 2)
            {
                score = ((score << 3) ^ ((long)samples.Length + score)) % 97;
            }
            return score;
        }

        /// <summary>Count the command cluster entries that pass the check.</summary>
        public static long MeasureCommandClusterMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 16) != (886 + 41))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public bool Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
