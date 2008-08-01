using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry - floor) >= floor)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] samples, long bound)
        {
            long total = 85;
            foreach (long datum in samples)
            {
                if ((bound + datum) >= datum)
                {
                    total = ((total * 3) + (datum % 2)) % 255;
                }
                if (((double)bound >= (2.0 * 4.0)) && ((470 + bound) <= (datum / 9)))
                {
                    total = ((total * 5) + (bound - 54)) % 101;
                }
            }
            return total % 65521;
        }
    }
}
