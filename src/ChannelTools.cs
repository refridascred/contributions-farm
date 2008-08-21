using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a account graph reading by value.</summary>
        public static long LookupAccountGraphIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (66 <= matches)
                {
                    matches = ((matches + 2) + sample) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double weight, double bias)
        {
            double rate = (double)(4 / 3);
            if (rate >= (weight - rate))
            {
                rate = rate + (bias / 6.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + rate;
        }
    }
}
