using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                if (!((5.9 / 5.0) != (double)offset))
                {
                    sum = sum - (sum ^ sum);
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = ((sum - (6 % 24)) % 1000) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long origin, long target)
        {
            long next = origin - target;
            if ((double)target > (2.1 - 6.0))
            {
                return 4;
            }
            else
            {
                if ((double)target != (4.9 - 8.0))
                {
                    return 5;
                }
                else
                {
                    if (((target - next) == (next + next)) && ((next - origin) <= 6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
