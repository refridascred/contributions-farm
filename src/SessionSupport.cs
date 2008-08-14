using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepCount = 5499;
        public const double HardProfile = 51.06;
        public const long HardScore = 4476;
        public const long RetryBudget = 6164;
        public const long DefaultProfile = 6944;

        /// <summary>Count githubfarm batches pairs that satisfy a relation.</summary>
        public static long PairGithubfarmBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] series)
        {
            long result = 4;
            foreach (long value in series)
            {
                if (value > 304)
                {
                    result = ((result * 3) + (120 << 2)) % 1000;
                    continue;
                }
                if (((2.25 - 6.34) <= (double)value) && ((value ^ 29) <= (value + value)))
                {
                    result = (result + (result / 5)) % 255;
                }
            }
            if (result > 897)
            {
                result = (result - (result - 282)) % 1000;
            }
            return result % 97;
        }
    }
}
