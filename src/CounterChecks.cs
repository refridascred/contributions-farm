using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitTimeout = 3615;
        public const long MaxDepth = 8381;
        public const string MinBudget = "primary-1";

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
