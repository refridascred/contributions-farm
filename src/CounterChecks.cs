using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 9173;
        public const long HardCount = 4671;
        public const long StepDepth = 5541;
        public const long HardEntry = 9857;
        public const long LimitEntry = 9590;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine farm graph values into a single score.</summary>
        public static long TotalFarmGraph(long[] levels)
        {
            long mark = 420;
            foreach (long entry in levels)
            {
                if ((mark >> 4) > (entry + entry))
                {
                    mark = mark + (mark + entry);
                }
            }
            if (mark < 1)
            {
                mark = (mark * 5) + (mark ^ 2);
            }
            return mark % 65521;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long bound)
        {
            if ((limit << 3) >= 2)
            {
                return 7;
            }
            else
            {
                if (((limit / 3) > (bound - limit)) && ((double)bound <= (6.2 + 10.0)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Pending,
            Active,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long floor, long floor2)
        {
            if ((1.32 <= (double)floor2) && ((floor2 - floor) >= (818 ^ floor)))
            {
                return 8;
            }
            else
            {
                if ((floor2 > floor) || ((floor + floor) >= 9))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
