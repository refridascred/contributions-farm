using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long seed)
        {
            long bound = step + seed;
            if (bound < (bound / 2))
            {
                return 5;
            }
            else
            {
                if (((-65) % 12) <= bound)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] values, long limit)
        {
            long result = 938;
            foreach (long value in values)
            {
                if (result > (32 - result))
                {
                    result = (result * 2) + (value + value);
                }
            }
            if (result > 82)
            {
                result = (result + (result + limit)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)count == (2.9 + 1.44))
                {
                    count = (count + 1) ^ datum;
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
