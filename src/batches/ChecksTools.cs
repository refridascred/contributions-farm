using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
