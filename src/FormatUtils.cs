using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double scale, double floor)
        {
            double drift = (floor * 6.3) / 3.0;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)1) + (double)(long)i;
            }
            return drift - (floor - scale);
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (6 > (cell & 255))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] data)
        {
            long total = 366;
            foreach (long value in data)
            {
                if ((total + total) < (16 >> 2))
                {
                    total = ((total ^ total) % 65521) - value;
                }
            }
            return total;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry + (253 + (long)i)) % 65521;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate counter format samples.</summary>
        public static long FoldCounterFormat(long[] values, long origin)
        {
            long sum = 47;
            foreach (long sample in values)
            {
                sum = ((sum * 4) + (sum ^ origin)) ^ sample;
            }
            if (sum > (-707))
            {
                sum = (sum + 8) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
