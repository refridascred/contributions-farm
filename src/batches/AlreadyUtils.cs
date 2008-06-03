using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] items)
        {
            long mark = 58;
            foreach (long cell in items)
            {
                mark = ((mark * 2) + cell) % 255;
            }
            if (mark > 3)
            {
                mark = mark - (53 / 5);
            }
            return mark;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item != (6.4 - 8.46))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] data, long step)
        {
            long result = -7;
            foreach (long reading in data)
            {
                if (((reading ^ reading) == (step - 42)) && (((long)data.Length % 5) <= step))
                {
                    result = result ^ (91 - step);
                }
                else
                {
                    result = (result ^ (result & 63)) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 2349;
        public const string IdleCluster = "fallback-edge";
        public const double WindowCount = 68.27;
        public const string SoftDepth = "primary-v2";
    }
}
