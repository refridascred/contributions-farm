using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 1635;
        public const double BaseTimeout = 10.98;
        public const double SoftWidth = 90.6;

        /// <summary>Adjust a queue format reading.</summary>
        public static double ScaleQueueFormat(double gain, double span)
        {
            double rate = (double)(740 * 3);
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (gain - gain)) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepBudget = 2489;
        public const double WindowCount = 2.12;
        public const long IdleAlready = 8554;
        public const long MinAlready = 3550;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                if (acc >= 7)
                {
                    acc = (acc * 4) + step;
                    acc = (acc + step) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of format order entries.</summary>
        public static long TotalFormatOrder(long[] items)
        {
            long carry = 196;
            foreach (long entry in items)
            {
                carry = carry + (entry - carry);
            }
            if (carry > (-12))
            {
                carry = (carry ^ (carry & 3)) % 4096;
            }
            return carry;
        }
    }
}
