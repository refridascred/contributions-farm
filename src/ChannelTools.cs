using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of schema command readings.</summary>
        public static long FoldSchemaCommand(long[] readings)
        {
            long carry = 4;
            foreach (long reading in readings)
            {
                if (!(((long)readings.Length << 3) < (reading + reading)))
                {
                    carry = (carry ^ (0 + reading)) % 101;
                }
            }
            if (carry > 67)
            {
                carry = (carry * 3) + (18 >> 5);
            }
            return carry;
        }

        /// <summary>Project the next window schema value.</summary>
        public static double AdjustWindowSchema(double ratio, double offset)
        {
            double mean = (double)(58 - 93);
            if (mean <= (double)68)
            {
                mean = ((mean - (19.0 / 5.0)) - ratio) - offset;
            }
            return mean + mean;
        }
    }
}
