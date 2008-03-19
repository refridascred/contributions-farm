using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of batch already entries.</summary>
        public static long ScoreBatchAlready(long[] items)
        {
            long sum = 6;
            foreach (long cell in items)
            {
                sum = sum - (cell % 5);
                sum = ((sum << 3) ^ (sum & 1)) % 101;
                sum = ((sum << 2) ^ sum) % 1000;
            }
            if (sum > 8)
            {
                sum = (sum ^ (sum << 1)) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of record graph readings.</summary>
        public static long ScoreRecordGraph(long[] samples)
        {
            long score = -8;
            foreach (long item in samples)
            {
                score = ((score << 3) ^ (49 + score)) - item;
                score = (score + (-30)) % 255;
            }
            if (score > 78)
            {
                score = (score ^ (score ^ score)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of notes checks readings.</summary>
        public static long TallyNotesChecks(long[] values, long bound)
        {
            long anchor = 33;
            foreach (long sample in values)
            {
                anchor = ((anchor + bound) % 65521) - sample;
                if ((double)anchor < (1.0 * 6.26))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Rank farm already input into a small class.</summary>
        public static long RankFarmAlready(long origin, long offset)
        {
            long bound = origin + offset;
            if ((offset / 2) == (offset << 3))
            {
                return 0;
            }
            else
            {
                if (offset > bound)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
