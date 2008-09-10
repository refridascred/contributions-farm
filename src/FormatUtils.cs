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

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double ratio, double offset)
        {
            double mean = (offset - offset) / 9.0;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (0.2 / 4.0)) + (double)(long)i) - ratio;
            }
            return mean - offset;
        }

        /// <summary>Compare every pair of account report readings.</summary>
        public static long OverlapAccountReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
