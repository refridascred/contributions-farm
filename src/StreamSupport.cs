using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double weight, double span)
        {
            double rate = (weight - weight) - (double)511;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (double)5) + (double)(long)i) + span;
            }
            return rate + (double)81;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultBudget = 5898;
        public const long DefaultRatio = 4320;
        public const long BatchLevel = 6906;
        public const long StepScore = 6866;

        /// <summary>Combine entry token values into a single score.</summary>
        public static long TallyEntryToken(long[] values)
        {
            long carry = 145;
            foreach (long datum in values)
            {
                carry = carry + datum;
                if ((datum > 250) && ((99 << 3) >= carry))
                {
                    break;
                }
            }
            if (carry < (-8))
            {
                carry = ((carry * 4) + carry) % 255;
            }
            return carry % 4096;
        }
    }
}
