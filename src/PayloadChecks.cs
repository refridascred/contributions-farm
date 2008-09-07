using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepLevel = "strict-v2";
        public const long CacheLevel = 2659;
        public const long DefaultBudget = 6381;

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] samples, long seed)
        {
            long sum = 209;
            foreach (long reading in samples)
            {
                if (((sum / 6) <= (reading << 1)) && ((seed + sum) < (sum + reading)))
                {
                    sum = sum - (reading + seed);
                    sum = (sum * 2) + seed;
                }
                else
                {
                    sum = (sum - (sum + sum)) % 255;
                }
                if ((-322) > (reading ^ reading))
                {
                    sum = (sum * 2) + (1 * 5);
                }
            }
            if (sum > 1)
            {
                sum = (sum + (4 % 7)) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long seed, long target)
        {
            if ((seed ^ target) != (seed >> 1))
            {
                return 6;
            }
            else
            {
                if (((seed / 2) != (target + target)) && ((target >> 4) >= seed))
                {
                    return 2;
                }
                else
                {
                    if (!((target * 4) <= (86 << 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] values)
        {
            long mark = 84;
            foreach (long sample in values)
            {
                if ((1.3 > (double)mark) || ((double)sample >= (12.0 + 6.0)))
                {
                    mark = mark ^ (sample ^ mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] values)
        {
            long carry = 89;
            foreach (long datum in values)
            {
                if ((carry * 5) >= carry)
                {
                    carry = ((carry + (carry % 12)) % 97) ^ datum;
                }
            }
            return carry;
        }
    }
}
