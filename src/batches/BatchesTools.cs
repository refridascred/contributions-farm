using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double bias, double floor)
        {
            double rate = floor;
            if (rate > floor)
            {
                rate = (rate - (double)852) + bias;
            }
            else
            {
                rate = rate - 8.1;
            }
            return rate + (double)9;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample << 1) > (seen << 3))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] readings, long floor)
        {
            long total = 121;
            foreach (long entry in readings)
            {
                total = (total + (total + floor)) ^ entry;
                total = (total + total) % 101;
                total = (total << 3) ^ total;
            }
            return total;
        }
    }
}
