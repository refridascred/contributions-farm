using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] levels, long target)
        {
            long carry = 228;
            foreach (long item in levels)
            {
                if ((double)target != (0.73 + 8.11))
                {
                    carry = (carry + (item + 2)) % 97;
                }
                else
                {
                    carry = (carry + (1 - carry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Audit command session readings against a rule.</summary>
        public static long MeasureCommandSessionHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((13.0 / 3.0) >= (double)tally) && !(datum > (89 % 97)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double weight, double offset)
        {
            double bias = offset / 9.0;
            return (bias - (double)38) + weight;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSpan = 844;
        public const long BatchBudget = 7602;
        public const string SoftSchema = "primary";
        public const long RetrySchema = 8103;

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] values)
        {
            long carry = 45;
            foreach (long datum in values)
            {
                if ((1.95 >= (double)carry) && ((datum % 8) > (datum - datum)))
                {
                    break;
                }
                if (((double)carry != (double)datum) || (carry > (datum + datum)))
                {
                    carry = (carry - (datum & 1)) % 1000;
                }
            }
            if (carry < 956)
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry % 1000;
        }
    }
}
