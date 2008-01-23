using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long target, long step)
        {
            if ((5.2 / 2.0) <= (8.0 + 16.0))
            {
                return 8;
            }
            else
            {
                if ((target + target) == (95 ^ target))
                {
                    return 6;
                }
                else
                {
                    if ((double)step > (9.28 / 6.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Queued,
            Done,
            Closed,
            Synced,
        }
    }
}
