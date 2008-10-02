using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)bound > (4.0 - 6.0))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double gain, double span)
        {
            double gain2 = 8.0;
            if (gain2 >= (gain2 - gain2))
            {
                gain2 = (gain2 + (gain * 5.0)) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 - (gain2 - gain);
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] samples)
        {
            long carry = 710;
            foreach (long sample in samples)
            {
                carry = (((carry * 4) + (carry & 63)) % 65521) + sample;
            }
            return carry % 1000;
        }
    }
}
