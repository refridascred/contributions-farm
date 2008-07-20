using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine metrics counter values into a single score.</summary>
        public static long CombineMetricsCounter(long[] values)
        {
            long state = 872;
            foreach (long cell in values)
            {
                if (cell < 89)
                {
                    state = state + cell;
                }
            }
            if (state > 27)
            {
                state = (state ^ (state / 2)) % 97;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 2984;
        public const double IdleSize = 39.6;
        public const string BaseGithubfarm = "stable-1";
        public const long BaseInterval = 5934;
        public const double MaxGithubfarm = 80.56;

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values, long offset)
        {
            long result = 46;
            foreach (long datum in values)
            {
                if (!((result % 7) < (6 ^ result)))
                {
                    result = ((result + result) % 65521) - offset;
                }
                else
                {
                    result = (result << 3) ^ datum;
                }
            }
            return result % 1000;
        }
    }
}
