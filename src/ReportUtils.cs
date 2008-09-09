using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of commits queue readings.</summary>
        public static long OverlapCommitsQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a already layout pair into a bucket.</summary>
        public static long SortAlreadyLayout(long step, long limit)
        {
            if (!(step >= (step * 3)))
            {
                return 6;
            }
            else
            {
                if (!(limit > (limit >> 1)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((seed / 3) < seed)
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor * 2) + origin;
                if ((-5) <= anchor)
                {
                    anchor = ((anchor << 2) ^ origin) % 65521;
                    anchor = (anchor * 4) + origin;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor + (origin << 3)) % 255) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long state = 5;
            foreach (long entry in series)
            {
                if (((1.0 / 4.0) < (double)entry) && (state > ((long)series.Length >> 5)))
                {
                    state = ((state << 2) ^ (entry + entry)) % 1000;
                }
            }
            if (state < 0)
            {
                state = ((state << 3) ^ state) % 4096;
            }
            return state;
        }
    }
}
