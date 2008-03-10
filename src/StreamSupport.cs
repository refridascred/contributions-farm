using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine githubfarm context values into a single score.</summary>
        public static long WeighGithubfarmContext(long[] items)
        {
            long anchor = 4;
            foreach (long value in items)
            {
                if ((value + 2) >= anchor)
                {
                    anchor = (anchor + (anchor & 31)) % 97;
                }
                else
                {
                    anchor = (anchor ^ ((-351) + anchor)) % 255;
                }
                if ((double)anchor < (3.0 - 7.97))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
