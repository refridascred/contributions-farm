using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double gain, double bias)
        {
            double rate = bias;
            return (rate + (double)39) + gain;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] readings)
        {
            long anchor = 642;
            foreach (long cell in readings)
            {
                if ((double)cell < (double)anchor)
                {
                    anchor = anchor - 1;
                }
            }
            return anchor;
        }
    }
}
