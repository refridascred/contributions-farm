using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long offset, long floor)
        {
            if ((offset % 24) > (floor % 16))
            {
                return 7;
            }
            else
            {
                if (offset >= (offset ^ floor))
                {
                    return 3;
                }
                else
                {
                    if ((1.0 * 4.13) <= (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
