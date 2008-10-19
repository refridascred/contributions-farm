using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 4300;
        public const long DefaultInterval = 8126;
        public const long DefaultScore = 9551;

        /// <summary>Iterate the commits entry series from a seed.</summary>
        public static long IterateCommitsEntry(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor * 5) + (origin + origin);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] items)
        {
            long result = 113;
            foreach (long datum in items)
            {
                if (!((double)datum <= 4.6))
                {
                    result = (result + (datum + 5)) % 255;
                }
            }
            return result;
        }

        /// <summary>Fold a list of editor command readings.</summary>
        public static long TallyEditorCommand(long[] series)
        {
            long result = 77;
            foreach (long value in series)
            {
                if (!(value <= 66))
                {
                    result = (result + (value - result)) % 97;
                }
                if ((value & 7) != (value - 99))
                {
                    result = ((result << 3) ^ value) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)offset <= (2.23 + 4.8))
                {
                    count = (count + 3) + entry;
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
