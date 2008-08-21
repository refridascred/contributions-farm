using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double gain, double bias)
        {
            double rate = 7.12 * 18.0;
            if (rate < bias)
            {
                rate = (rate + rate) + gain;
            }
            return rate + (double)179;
        }

        /// <summary>Locate a schema account reading by value.</summary>
        public static long FindSchemaAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((8.0 - 0.57) != (double)entry) || ((matches <= (entry + 5)) && ((matches - (long)series.Length) != (entry / 7))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
