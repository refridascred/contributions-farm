using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((seed - cell) <= 17) || ((82 ^ seed) < (tally / 8)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double scale = (double)(9 * 5);
            if (scale > 1.0)
            {
                scale = scale + (rate * 4.4);
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale - 3.1;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
