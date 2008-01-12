using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Active,
            Pending,
            New,
            Dropped,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long limit, long bound)
        {
            if (((bound - limit) == (bound + limit)) || ((limit + bound) <= limit))
            {
                return 6;
            }
            else
            {
                if (limit > bound)
                {
                    return 0;
                }
                else
                {
                    if ((limit - limit) < (limit - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound % 12) >= bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
