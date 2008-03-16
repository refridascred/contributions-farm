using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultInterval = 1036;
        public const string RetryBudget = "latest";
        public const string MinScore = "open-1";
        public const long SoftSpan = 5714;

        /// <summary>Classify a githubfarm checks pair into a bucket.</summary>
        public static long SortGithubfarmChecks(long target, long step)
        {
            if (step >= (step - target))
            {
                return 2;
            }
            else
            {
                if ((3.11 + 3.32) >= (double)step)
                {
                    return 4;
                }
                else
                {
                    if (((step ^ target) > step) && ((step % 8) > (target + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step >> 5) != (step & 31))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
