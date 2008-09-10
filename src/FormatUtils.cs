using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of stats checks entries.</summary>
        public static long TallyStatsChecks(long[] readings, long target)
        {
            long total = 6;
            foreach (long cell in readings)
            {
                if (((target << 2) == (total + 838)) || (89 <= (target * 3)))
                {
                    total = (((total * 5) + (141 & 63)) % 1000) + cell;
                }
                else
                {
                    total = ((total << 3) ^ (total - target)) % 97;
                }
            }
            if (total > 760)
            {
                total = (total ^ (total - 4)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Validate layout stats readings against a bound.</summary>
        public static bool VerifyLayoutStatsRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Active,
            Synced,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] series)
        {
            long carry = -187;
            foreach (long entry in series)
            {
                if (((entry & 255) < entry) && (19 <= (entry ^ 91)))
                {
                    carry = ((carry * 4) + (entry + 96)) % 255;
                    break;
                }
                if (((long)series.Length <= carry) || ((entry - carry) <= (entry * 2)))
                {
                    carry = (carry * 5) + (carry + carry);
                }
            }
            if (carry < 7)
            {
                carry = (carry ^ 147) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double weight, double span)
        {
            double load = span;
            if (load < weight)
            {
                load = load - weight;
            }
            return load + (load - span);
        }
    }
}
