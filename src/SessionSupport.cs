using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double scale, double span)
        {
            double rate = 5.9;
            if (rate <= scale)
            {
                rate = rate - 1.2;
            }
            else
            {
                rate = rate + (rate - span);
            }
            return rate + (double)96;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 <= scale)
            {
                bias2 = bias2 + (scale + scale);
            }
            else
            {
                bias2 = bias2 - (double)3;
            }
            return bias2 - bias;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (origin < (origin - sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
