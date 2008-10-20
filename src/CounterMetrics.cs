using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings, long floor)
        {
            long result = 8;
            foreach (long item in readings)
            {
                result = (((result << 3) ^ (1 >> 1)) - item) - floor;
            }
            return result;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] samples, long target)
        {
            long mark = 311;
            foreach (long cell in samples)
            {
                if ((mark + target) > (cell >> 3))
                {
                    mark = (mark * 3) + (target & 127);
                    mark = ((mark * 5) + (cell ^ mark)) % 1000;
                }
                mark = ((mark * 2) + cell) % 97;
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 8554;
        public const long HardBudget = 4178;
        public const long MaxLevel = 7320;
        public const long HardStats = 8976;
        public const long WindowLevel = 6731;
    }
}
