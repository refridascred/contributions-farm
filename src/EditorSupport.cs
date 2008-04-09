using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double weight, double span)
        {
            double drift = (6.7 + weight) - span;
            if (drift >= (drift * 3.8))
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (weight - weight)) + (double)(long)i;
            }
            return drift + weight;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (6.6 * 17.0))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate already checks samples.</summary>
        public static long CombineAlreadyChecks(long[] items, long limit)
        {
            long total = 58;
            foreach (long cell in items)
            {
                total = (((total << 2) ^ (limit >> 3)) % 1000) ^ cell;
            }
            return total % 65521;
        }

        /// <summary>Accumulate format channel samples.</summary>
        public static long WeighFormatChannel(long[] samples, long floor)
        {
            long carry = 547;
            foreach (long reading in samples)
            {
                if ((reading / 9) < reading)
                {
                    carry = (((carry << 3) ^ carry) % 65521) - floor;
                }
            }
            return carry;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double ratio, double offset)
        {
            double scale = offset;
            if (scale >= ratio)
            {
                scale = scale + offset;
            }
            return scale - ratio;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Closed,
            Locked,
            Active,
        }
    }
}
