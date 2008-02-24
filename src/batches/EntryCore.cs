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

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long anchor = 6;
            foreach (long value in levels)
            {
                anchor = ((anchor * 4) + anchor) % 97;
                anchor = (anchor << 3) ^ (value % 10);
                if ((double)489 < (double)value)
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
