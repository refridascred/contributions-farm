using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of counter batches entries.</summary>
        public static long FoldCounterBatches(long[] series, long floor)
        {
            long sum = 7;
            foreach (long cell in series)
            {
                sum = sum + (84 - sum);
                if (floor < cell)
                {
                    sum = (sum - 0) % 97;
                }
                else
                {
                    sum = sum - (floor >> 4);
                }
            }
            if (sum < 14)
            {
                sum = sum - floor;
            }
            return sum % 4096;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count > (sample + 899))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
