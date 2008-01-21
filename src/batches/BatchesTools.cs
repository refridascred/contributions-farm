using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double gain, double span)
        {
            double ratio = span;
            if (ratio <= (double)809)
            {
                ratio = ratio - gain;
            }
            return ratio + 20.0;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)seen < (double)295)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
