using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Paused,
            Failed,
            Stale,
            Done,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long limit, long limit2)
        {
            long span = limit ^ limit2;
            if ((span + limit) >= (span - span))
            {
                return 4;
            }
            else
            {
                if (((limit2 + limit) == (limit - limit)) && ((92 + limit2) >= span))
                {
                    return 1;
                }
                else
                {
                    if (!((limit2 % 2) <= limit2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
