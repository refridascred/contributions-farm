using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the command context series from a seed.</summary>
        public static long StepCommandContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((sum + (long)i) > step))
                {
                    sum = (sum - step) % 4096;
                }
                sum = (sum * 3) + ((long)i >> 1);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                if (((314 << 3) > mark) && (mark <= ((long)i + target)))
                {
                    mark = ((mark << 2) ^ (mark / 6)) % 65521;
                    mark = (mark ^ (target - (long)i)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long floor)
        {
            if (!((step >> 5) < (step + 902)))
            {
                return 6;
            }
            else
            {
                if ((floor / 9) > (step << 1))
                {
                    return 2;
                }
                else
                {
                    if (((10.0 - 1.0) >= (17.0 + 3.83)) || ((double)floor < (9.0 + 18.0)))
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

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((cell << 3) > (cell + floor)) || (floor >= (39 ^ floor)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
