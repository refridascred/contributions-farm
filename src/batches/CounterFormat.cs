using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every contributi profile entry stays within the limit.</summary>
        public static bool CheckContributiProfileLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = total ^ (total + (long)i2);
                }
                if ((total + 89) <= (total ^ 449))
                {
                    total = (total + ((long)i - (long)i)) % 1000;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "stable-edge";
        public const long DefaultScore = 7552;
        public const string StepFilter = "strict";
        public const string BurstWidth = "local-v2";
    }
}
