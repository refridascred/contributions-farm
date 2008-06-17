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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!(sum <= (limit >> 3)))
                {
                    sum = sum + (long)i;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 2322;
        public const long IdleCount = 6481;
        public const string LimitTimeout = "legacy-edge";
    }
}
