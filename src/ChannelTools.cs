using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long limit, long offset)
        {
            if (((double)limit > 0.9) && ((limit - offset) >= (limit << 3)))
            {
                return 0;
            }
            else
            {
                if (!(offset < (limit + 567)))
                {
                    return 3;
                }
                else
                {
                    if (offset >= (99 >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)limit >= (6.11 + 9.6)) && (((-39) ^ limit) <= (offset + offset)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            New,
            Dropped,
            Draft,
        }
    }
}
