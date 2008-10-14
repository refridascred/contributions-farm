using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (seed < (95 + 5))
                {
                    count = (count + 2) - cell;
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
