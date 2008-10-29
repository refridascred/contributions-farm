using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a layout commits counter forward.</summary>
        public static long IterateLayoutCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 18; i++)
            {
                double scale = (double)target / 8.0;
                if (((double)score > scale) && (score <= (score << 1)))
                {
                    scale = scale - scale;
                }
                else
                {
                    scale = scale - (scale / 5.0);
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
