using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a editor buffer pair into a bucket.</summary>
        public static long BucketEditorBuffer(long limit, long limit2)
        {
            long cur = limit - limit2;
            if ((limit >= 587) && ((8.5 - 5.12) != (double)limit))
            {
                return 7;
            }
            else
            {
                if ((187 - limit) > (cur * 5))
                {
                    return 8;
                }
                else
                {
                    if ((cur << 1) == (cur * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every counter command entry stays within the limit.</summary>
        public static bool VerifyCounterCommandBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
