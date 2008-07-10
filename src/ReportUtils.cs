using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] levels, long origin)
        {
            long anchor = 4;
            foreach (long reading in levels)
            {
                anchor = ((anchor ^ reading) % 4096) - origin;
                anchor = anchor ^ (reading + anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((hits + hits) < sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Stale,
            Locked,
            Failed,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] items, long seed)
        {
            long total = 651;
            foreach (long entry in items)
            {
                if ((double)seed != (17.0 + 6.41))
                {
                    total = total - (seed + entry);
                }
                else
                {
                    total = (total ^ (total >> 4)) % 97;
                }
            }
            return total % 65521;
        }
    }
}
