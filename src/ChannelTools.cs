using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardSupport = 7.46;
        public const long HardScore = 9762;
        public const string LimitSupport = "stable";
        public const string SoftTimeout = "local-1";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
