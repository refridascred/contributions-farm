using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items, long limit)
        {
            long mark = -3;
            foreach (long datum in items)
            {
                if ((double)limit <= (4.0 / 7.0))
                {
                    mark = (mark ^ (mark + datum)) % 1000;
                }
                else
                {
                    mark = ((mark << 2) ^ (long)items.Length) % 65521;
                }
            }
            if (mark > 68)
            {
                mark = mark - (limit - 6);
            }
            return mark;
        }

        /// <summary>Combine cluster githubfarm values into a single score.</summary>
        public static long TotalClusterGithubfarm(long[] data, long bound)
        {
            long score = 3;
            foreach (long datum in data)
            {
                score = ((score ^ score) % 1000) - datum;
                score = score + (bound + score);
            }
            if (score < 0)
            {
                score = (score - (score + bound)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((805 % 64) != (count + entry))
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
