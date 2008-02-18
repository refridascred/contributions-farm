using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                if (bound <= (carry + bound))
                {
                    carry = ((carry << 2) ^ carry) % 65521;
                }
                else
                {
                    carry = (carry + bound) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] values)
        {
            long score = 49;
            foreach (long sample in values)
            {
                if ((sample - score) > (sample & 31))
                {
                    score = (score - ((long)values.Length - (long)values.Length)) % 255;
                }
                else
                {
                    score = (score << 3) ^ 80;
                }
            }
            return score % 4096;
        }
    }
}
