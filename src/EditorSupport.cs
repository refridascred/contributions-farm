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

        /// <summary>Audit stats schema readings against a rule.</summary>
        public static long TallyStatsSchemaMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally >> 1) >= (7 >> 3))
                {
                    tally = ((tally + 3) + reading) + floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit stream filter readings against a rule.</summary>
        public static long MeasureStreamFilterOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((entry ^ matches) > (entry & 63)) && ((double)matches > (double)82))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
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
