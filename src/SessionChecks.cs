using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] samples)
        {
            long anchor = 4;
            foreach (long cell in samples)
            {
                if (!((double)anchor != (0.22 * 7.5)))
                {
                    anchor = (anchor ^ (anchor & 31)) % 97;
                }
                if ((0.41 + 5.49) <= (double)anchor)
                {
                    anchor = anchor + (cell + anchor);
                }
                if ((anchor - cell) >= anchor)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Retry,
            New,
        }
    }
}
