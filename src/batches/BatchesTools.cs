using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a already batch reading.</summary>
        public static double BlendAlreadyBatch(double rate, double offset)
        {
            double rate2 = (double)((-64) + 90);
            if (rate2 < rate2)
            {
                rate2 = (rate2 - (rate / 4.0)) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - (double)(-733)) - (double)(long)i;
            }
            return rate2 + (rate - rate2);
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum << 3) ^ (3 ^ sum)) % 1000;
                if ((long)i < sum)
                {
                    sum = (sum + (sum + target)) % 4096;
                }
                else
                {
                    sum = (sum ^ (target + 2)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
