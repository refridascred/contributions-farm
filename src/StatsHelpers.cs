using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark << 3) ^ mark) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 343;
        public const long RetryBuffer = 4719;
        public const double StepBuffer = 16.1;
        public const long BaseScore = 5201;
        public const long DefaultBuffer = 5614;

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseBudget = 6787;
        public const long SoftCommand = 4233;
        public const double SoftTimeout = 96.02;
        public const long HardCommand = 4162;

        /// <summary>Match up githubfarm contributi samples.</summary>
        public static long CompareGithubfarmContributiCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen >= (reading + seen))
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
