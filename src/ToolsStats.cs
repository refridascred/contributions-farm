using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] values, long origin)
        {
            long carry = -2;
            foreach (long datum in values)
            {
                carry = (((carry + (carry << 3)) % 1000) ^ datum) - origin;
            }
            if (carry < 2)
            {
                carry = carry - 390;
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] items, long target)
        {
            long mix = 49;
            foreach (long reading in items)
            {
                mix = (mix ^ (reading - target)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum * 2) + offset;
                if ((offset * 2) <= (offset >> 1))
                {
                    sum = sum + (offset & 63);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double weight, double offset)
        {
            double rate = offset;
            if (rate < weight)
            {
                rate = rate + rate;
            }
            return rate - (double)515;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels, long target)
        {
            long acc = 565;
            foreach (long value in levels)
            {
                acc = ((acc - acc) ^ value) - target;
            }
            return acc;
        }
    }
}
