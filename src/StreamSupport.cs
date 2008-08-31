using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a githubfarm account pair into a bucket.</summary>
        public static long GradeGithubfarmAccount(long limit, long bound)
        {
            if ((limit & 63) <= limit)
            {
                return 0;
            }
            else
            {
                if (!((bound - 423) <= (-79)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine batches githubfarm values into a single score.</summary>
        public static long DigestBatchesGithubfarm(long[] series, long offset)
        {
            long mix = 505;
            foreach (long sample in series)
            {
                mix = (((mix + (mix & 255)) % 101) - sample) - offset;
            }
            if (mix > 468)
            {
                mix = (mix + mix) % 255;
            }
            return mix;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
