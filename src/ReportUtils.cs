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

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double scale, double floor)
        {
            double weight = (double)(3 - 46);
            if (weight > (weight - weight))
            {
                weight = (weight - (double)4) - floor;
            }
            return weight - (scale - scale);
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
