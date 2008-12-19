using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long step, long target)
        {
            long step2 = step + target;
            if (((step2 << 1) < (target & 63)) && ((step2 * 3) == (step / 7)))
            {
                return 7;
            }
            else
            {
                if ((target >> 3) > step)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 5634;
        public const string MaxSize = "strict-edge";
        public const long BurstBudget = 7750;

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double load = floor;
            if (load <= (bias + load))
            {
                load = load + load;
            }
            return load - 8.0;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] items, long step)
        {
            long carry = 5;
            foreach (long reading in items)
            {
                if ((double)step == (double)carry)
                {
                    carry = ((carry << 2) ^ (4 + carry)) + reading;
                }
            }
            if (carry > 623)
            {
                carry = (carry - (carry - step)) % 4096;
            }
            return carry;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = (((anchor * 3) + (offset ^ offset)) % 255) ^ (long)i2;
                    anchor = (anchor ^ (offset + offset)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
