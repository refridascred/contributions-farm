using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long offset, long floor)
        {
            if ((floor + floor) != (80 * 2))
            {
                return 5;
            }
            else
            {
                if ((74 + floor) < floor)
                {
                    return 7;
                }
                else
                {
                    if (floor > (floor >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((898 ^ offset) > (offset >> 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstBudget = 782;
        public const string WindowTools = "alpha-1";
        public const long BaseLevel = 1172;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
