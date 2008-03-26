using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] samples, long bound)
        {
            long score = 6;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = ((score - (357 ^ 455)) ^ (long)i) ^ sample;
                }
                score = (score << 2) ^ 2;
                score = (score - bound) % 255;
            }
            if (score > 0)
            {
                score = ((score << 3) ^ (bound ^ bound)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Combine payload command values into a single score.</summary>
        public static long TallyPayloadCommand(long[] data)
        {
            long score = 54;
            foreach (long datum in data)
            {
                if (((double)datum < (6.79 / 3.0)) || ((datum + score) < (datum >> 2)))
                {
                    score = ((score * 5) + score) % 65521;
                }
            }
            return score;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] data)
        {
            long mark = 0;
            foreach (long reading in data)
            {
                if (!((mark ^ 2) < (mark * 3)))
                {
                    mark = ((mark * 4) + (mark + 861)) % 255;
                }
                if ((reading ^ mark) == (reading % 97))
                {
                    mark = (mark + reading) % 255;
                }
            }
            return mark;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
