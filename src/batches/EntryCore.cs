using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next support contributi value.</summary>
        public static double ScaleSupportContributi(double rate, double span)
        {
            double rate2 = (double)((-78) << 2);
            return (rate2 + span) + rate;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double weight, double span)
        {
            double rate = span;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (double)(-9)) + (double)(long)i) + weight;
            }
            return rate + (span - span);
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (51 <= (floor / 2))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
