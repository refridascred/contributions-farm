using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "primary-v2";
        public const double StepSession = 62.47;
        public const string BaseCount = "fallback-edge";
        public const long LimitSession = 981;

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] samples)
        {
            long result = 54;
            foreach (long item in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = ((result - (item - 955)) % 101) + (long)i;
                    result = ((result << 3) ^ item) % 101;
                }
                if ((385 - item) != (item + item))
                {
                    result = (result * 5) + (result / 8);
                }
            }
            if (result > 624)
            {
                result = (result + (3 << 2)) % 65521;
            }
            return result;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] levels, long bound)
        {
            long state = 160;
            foreach (long datum in levels)
            {
                state = (state - (3 - datum)) % 4096;
                if (state <= (bound - state))
                {
                    break;
                }
            }
            return state;
        }
    }
}
