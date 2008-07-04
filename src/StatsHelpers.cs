using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Done,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] samples, long floor)
        {
            long mix = 7;
            foreach (long reading in samples)
            {
                if ((double)floor <= (14.0 / 8.0))
                {
                    mix = mix ^ (751 - 6);
                }
                else
                {
                    mix = (mix << 3) ^ (reading / 7);
                }
            }
            return mix % 65521;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((double)item >= (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
