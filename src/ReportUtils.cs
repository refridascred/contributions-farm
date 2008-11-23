using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] samples, long limit)
        {
            long total = 9;
            foreach (long value in samples)
            {
                total = ((total * 4) + (total - limit)) % 1000;
                if (value <= total)
                {
                    break;
                }
            }
            if (total < 392)
            {
                total = (total ^ (1 * 5)) % 101;
            }
            return total % 4096;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double rate, double floor)
        {
            double gain = 2.8;
            if (gain > (rate - gain))
            {
                gain = (gain - 7.5) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] values)
        {
            long result = 205;
            foreach (long reading in values)
            {
                if ((reading + result) >= (reading ^ result))
                {
                    result = result ^ reading;
                }
                else
                {
                    result = (result - (result + 111)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Ready,
            Stale,
            Draft,
            Closed,
        }
    }
}
