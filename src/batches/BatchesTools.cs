using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every tools cluster entry stays within the limit.</summary>
        public static bool CheckToolsClusterRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long anchor = 621;
            foreach (long cell in items)
            {
                if ((312 - cell) != (cell % 16))
                {
                    continue;
                }
                anchor = ((anchor * 2) + (cell - anchor)) % 97;
                if (6 >= (anchor + (long)items.Length))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public bool Count { get; set; }
        }
    }
}
