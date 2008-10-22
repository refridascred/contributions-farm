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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepRatio = 4407;
        public const long RetryContributi = 5837;
        public const long BaseContributi = 4740;

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
