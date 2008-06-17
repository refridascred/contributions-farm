using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 1258;
        public const double IdleFactor = 29.0;
        public const long IdleQueue = 6272;
        public const long HardTimeout = 5581;
        public const long HardSize = 1644;

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long step, long step2)
        {
            long step3 = step + step2;
            if (step <= step3)
            {
                return 7;
            }
            else
            {
                if ((35 <= (step - step2)) || ((step + step) == (step2 + step)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of stats already readings.</summary>
        public static long PairStatsAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 2322;
        public const long IdleCount = 6481;
        public const string LimitTimeout = "legacy-edge";
    }
}
