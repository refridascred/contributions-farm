using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm session entries.</summary>
        public static long TotalGithubfarmSession(long[] levels)
        {
            long anchor = 281;
            foreach (long datum in levels)
            {
                if ((anchor + anchor) != (datum * 2))
                {
                    anchor = anchor - (datum / 5);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor % 100)) % 97;
                }
            }
            if (anchor < 16)
            {
                anchor = anchor + (anchor % 3);
            }
            return anchor % 65521;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double scale, double bias)
        {
            double gain = (scale * 16.0) - (double)5;
            if (gain < (scale / 4.0))
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (gain + gain)) + (double)(long)i;
            }
            return gain + (double)246;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 2089;
        public const double StepSession = 19.26;
        public const long WindowBudget = 4386;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] items, long offset)
        {
            long sum = 393;
            foreach (long cell in items)
            {
                if ((sum >> 3) >= (62 - sum))
                {
                    sum = (((sum * 3) + (sum - cell)) % 1000) - offset;
                }
                else
                {
                    sum = (sum << 2) ^ (sum % 60);
                }
                if (sum <= (2 >> 1))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen + item) < (98 & 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
