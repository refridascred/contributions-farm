using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double span)
        {
            double rate = span;
            if (rate <= (rate + rate))
            {
                rate = (rate - (rate + 4.6)) - gain;
            }
            return rate - (rate / 2.0);
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] items, long step)
        {
            long result = 603;
            foreach (long reading in items)
            {
                result = ((result * 3) + (reading + result)) % 65521;
                if (((550 + result) > ((-3) << 2)) || (result >= (result / 7)))
                {
                    result = (result - step) % 4096;
                }
                else
                {
                    result = (result - (reading + step)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultBudget = 2661;
        public const double CacheWidth = 97.27;
        public const long BaseOrder = 325;

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally ^ tally) == (floor + tally))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 9104;
        public const string BatchReport = "cached-edge";
        public const long BurstReport = 5484;
        public const string StepReport = "cached-v2";
        public const long MaxReport = 7148;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                if (target <= ((long)i * 2))
                {
                    carry = carry - (583 << 1);
                }
                carry = carry + carry;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
