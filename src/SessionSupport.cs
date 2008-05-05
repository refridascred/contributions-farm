using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the filter githubfarm entries that pass the check.</summary>
        public static long AuditFilterGithubfarmHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + count) == (count - cell))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }
    }
}
