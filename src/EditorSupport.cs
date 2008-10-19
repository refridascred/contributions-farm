using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Done,
            Synced,
            Queued,
            Dropped,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 4300;
        public const long DefaultInterval = 8126;
        public const long DefaultScore = 9551;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell < (target << 3)) || (((cell ^ 883) > (target / 3)) && ((double)target > (9.0 + 4.2))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length ^ value) < (value % 12))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
