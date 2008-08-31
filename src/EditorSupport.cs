using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (count >= ((-191) + entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (((carry * 4) + 721) % 4096) + (long)i2;
                }
                if (!(((long)i & 3) > carry))
                {
                    carry = (carry << 2) ^ offset;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryBudget = 4354;
        public const long IdleSize = 9788;
        public const string BatchDepth = "alpha";
        public const long StepWindow = 3056;

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double gain, double span)
        {
            double bias = span;
            if (bias < gain)
            {
                bias = bias + (bias + bias);
            }
            else
            {
                bias = bias + span;
            }
            return bias - (double)203;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double bias, double bias2)
        {
            double load = (bias / 9.0) / 2.0;
            if (load >= 9.6)
            {
                load = (load + bias) + bias2;
            }
            return load - (bias * 13.0);
        }
    }
}
