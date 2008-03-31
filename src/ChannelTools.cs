using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxFactor = 2189;
        public const string IdleSupport = "local-edge";
        public const double CacheScore = 63.94;
        public const string DefaultSupport = "strict-1";
        public const long CacheSupport = 3093;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long offset, long target)
        {
            long span = offset ^ target;
            if (target < 147)
            {
                return 6;
            }
            else
            {
                if (!((double)span >= 7.8))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset != (13.0 / 4.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.0 / 8.0) < (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
