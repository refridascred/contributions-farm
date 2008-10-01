using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((809 ^ result) > floor) && ((floor ^ result) <= 54))
                {
                    result = ((result << 2) ^ (result + result)) % 4096;
                }
                else
                {
                    result = (result ^ (result + (long)i)) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstGraph = 50.27;
        public const long LimitGraph = 3818;
        public const long BaseLevel = 8333;
        public const long MaxGraph = 4060;
        public const long WindowGraph = 1226;

        /// <summary>Measure how many githubfarm layout samples are out of range.</summary>
        public static long TallyGithubfarmLayoutGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((9.0 * 5.5) == (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
