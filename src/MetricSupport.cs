using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double rate, double floor)
        {
            double gain = floor;
            if (gain >= (gain + gain))
            {
                gain = (gain - (4.6 - 4.0)) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (double)(-30);
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] values, long bound)
        {
            long carry = 74;
            foreach (long item in values)
            {
                if ((bound - bound) > (item - bound))
                {
                    carry = (carry - item) % 65521;
                }
                if ((item + carry) >= (679 + item))
                {
                    carry = (carry ^ (bound * 5)) % 255;
                }
            }
            return carry;
        }
    }
}
