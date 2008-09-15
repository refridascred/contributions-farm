using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a checks editor value against two limits.</summary>
        public static long BucketChecksEditor(long limit, long target)
        {
            if (((1.3 / 9.0) < (double)limit) || ((limit >> 2) < (limit ^ limit)))
            {
                return 4;
            }
            else
            {
                if ((3.2 + 12.0) > (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (!((double)target > (7.0 - 4.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit > (508 % 64)) || ((target + target) == (target + 28)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Synced,
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
