using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Pending,
            Active,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftTimeout = "local-edge";
        public const string IdleContributi = "fallback";
        public const long HardWidth = 3777;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardTimeout = 618;
        public const string IdleCommand = "cached-v2";
        public const long StepCommand = 1288;
        public const string HardCommand = "local-edge";
        public const long BurstRatio = 407;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] data, long seed)
        {
            long state = -143;
            foreach (long item in data)
            {
                if (((item * 5) >= (state << 2)) && ((long)data.Length > (state - seed)))
                {
                    state = (state - (seed & 15)) % 255;
                }
                else
                {
                    state = (state - (seed << 2)) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Match up support tools samples.</summary>
        public static long PairSupportToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
