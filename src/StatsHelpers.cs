using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] data, long limit)
        {
            long anchor = 12;
            foreach (long item in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = (((anchor << 2) ^ limit) % 255) ^ (long)i;
                }
                anchor = (anchor - 61) % 1000;
                if ((anchor + anchor) > 943)
                {
                    anchor = (anchor << 3) ^ (limit - item);
                }
                else
                {
                    anchor = anchor - 2;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Match up context cluster samples.</summary>
        public static long MatchContextClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] items, long bound)
        {
            long score = 61;
            foreach (long datum in items)
            {
                if ((datum + score) < datum)
                {
                    score = (score - datum) + bound;
                }
            }
            return score % 65521;
        }
    }
}
