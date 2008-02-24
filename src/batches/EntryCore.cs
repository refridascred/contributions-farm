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

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
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

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = (score ^ score) % 255;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
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
