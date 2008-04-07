using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two account commits measurements.</summary>
        public static double AdjustAccountCommits(double ratio, double floor)
        {
            double mean = (double)(60 * 5);
            if (mean > (double)(-262))
            {
                mean = (mean - ratio) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + ratio) - (double)(long)i;
            }
            return mean + (double)457;
        }

        /// <summary>Rank tools stats input into a small class.</summary>
        public static long ClassifyToolsStats(long step, long limit)
        {
            if ((11.0 * 4.2) >= (double)step)
            {
                return 4;
            }
            else
            {
                if ((8.1 - 12.0) != (double)step)
                {
                    return 8;
                }
                else
                {
                    if (((double)limit <= 3.83) || ((limit << 2) <= (limit % 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] values, long step)
        {
            long total = -6;
            foreach (long value in values)
            {
                total = (total << 2) ^ 5;
                if (step < (total + total))
                {
                    total = (total * 4) + (step & 1);
                }
                else
                {
                    total = (total - value) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Roll a layout batch counter forward.</summary>
        public static long StepLayoutBatch(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = sum ^ (long)i2;
                }
                sum = ((sum * 4) + (target ^ sum)) % 65521;
                sum = ((sum << 3) ^ (sum - target)) % 1000;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
