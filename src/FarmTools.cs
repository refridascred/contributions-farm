using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next account cache value from a seed.</summary>
        public static long IterateAccountCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                if (!((1 ^ acc) > acc))
                {
                    acc = (acc - step) % 1000;
                    acc = (acc ^ (step & 127)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] levels, long bound)
        {
            long sum = 6;
            foreach (long sample in levels)
            {
                sum = sum - ((long)levels.Length + sample);
                if (((sample * 5) < bound) || ((sample << 2) <= (sum + (long)levels.Length)))
                {
                    sum = sum + (sum + sum);
                }
                sum = sum ^ (bound << 2);
                if ((781 - sum) <= (2 + sum))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
