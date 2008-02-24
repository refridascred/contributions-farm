using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public double Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] data)
        {
            long score = 618;
            foreach (long item in data)
            {
                if (item >= (score >> 4))
                {
                    score = (score ^ (item + 351)) % 65521;
                }
            }
            if (score > 7)
            {
                score = ((score << 2) ^ score) % 65521;
            }
            return score;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
