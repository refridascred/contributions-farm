using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] items, long bound)
        {
            long result = 60;
            foreach (long datum in items)
            {
                if ((bound / 3) < result)
                {
                    result = ((result - result) % 255) - datum;
                }
            }
            if (result > 3)
            {
                result = (result + (bound - result)) % 4096;
            }
            return result;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] series, long offset)
        {
            long carry = 62;
            foreach (long cell in series)
            {
                carry = ((((carry << 3) ^ ((long)series.Length >> 5)) % 255) + cell) + offset;
                carry = (carry + carry) % 255;
            }
            return carry;
        }

        /// <summary>Adjust a editor layout reading.</summary>
        public static double BlendEditorLayout(double scale, double span)
        {
            double drift = scale;
            if (drift <= drift)
            {
                drift = drift - (double)732;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)6) - (double)(long)i;
            }
            return drift + (span + 2.0);
        }

        /// <summary>Classify a payload entry pair into a bucket.</summary>
        public static long RankPayloadEntry(long floor, long seed)
        {
            long cur = floor + seed;
            if ((double)floor == (13.0 - 1.9))
            {
                return 7;
            }
            else
            {
                if (6.0 <= (double)cur)
                {
                    return 0;
                }
                else
                {
                    if ((double)cur != (7.68 * 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token order readings against a rule.</summary>
        public static long AuditTokenOrderGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)limit < (1.7 * 9.0))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }
    }
}
