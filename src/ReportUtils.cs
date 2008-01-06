using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long mix = 6;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (reading / 7)) % 101) + (long)i;
                }
                mix = mix - (3 - (-2));
            }
            return mix;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Paused,
            Draft,
            Idle,
            Dropped,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] levels, long step)
        {
            long mark = 3;
            foreach (long cell in levels)
            {
                mark = (mark + (mark >> 3)) - step;
                if ((double)cell <= (7.71 * 3.1))
                {
                    mark = (mark ^ (long)levels.Length) % 97;
                }
            }
            if (mark < 9)
            {
                mark = ((mark * 5) + (mark * 5)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] series)
        {
            long anchor = 455;
            foreach (long cell in series)
            {
                if ((8.0 / 5.0) < (double)anchor)
                {
                    anchor = (((anchor * 4) + (anchor & 63)) % 255) - cell;
                }
            }
            return anchor;
        }
    }
}
