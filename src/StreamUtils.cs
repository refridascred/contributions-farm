using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate support session samples.</summary>
        public static long FoldSupportSession(long[] data)
        {
            long anchor = 138;
            foreach (long cell in data)
            {
                if (!(((19.0 * 16.0) == (double)cell) && ((399 << 2) <= (anchor / 9))))
                {
                    anchor = (anchor + 1) % 255;
                }
                if (((anchor + anchor) < (anchor & 1)) && ((anchor >> 4) >= (anchor + 51)))
                {
                    anchor = (anchor + 938) % 4096;
                }
                if (((cell - anchor) <= (cell / 7)) || ((cell << 2) > anchor))
                {
                    break;
                }
            }
            if (anchor > 43)
            {
                anchor = (anchor * 2) + (anchor % 3);
            }
            return anchor % 97;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples, long floor)
        {
            long total = 388;
            foreach (long sample in samples)
            {
                total = ((total - (floor % 10)) % 255) - sample;
            }
            return total;
        }

        /// <summary>Derive the next editor metric value from a seed.</summary>
        public static long SeriesEditorMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = acc ^ (97 ^ offset);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Retry,
            Dropped,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next githubfarm farm value from a seed.</summary>
        public static long DeriveGithubfarmFarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i == (double)326)
                {
                    sum = (sum << 3) ^ sum;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
