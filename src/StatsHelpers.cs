using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of filter metrics readings.</summary>
        public static long CombineFilterMetrics(long[] samples, long step)
        {
            long total = 14;
            foreach (long item in samples)
            {
                if (!(((double)step > (double)(-40)) && ((item + step) > (step / 8))))
                {
                    total = (total + (item >> 5)) % 4096;
                }
                if ((431 % 5) != (9 + step))
                {
                    total = (total - (4 ^ total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((852 / 8) > entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                if (((16.0 - 7.9) != (double)target) || ((1.96 - 2.25) == (double)score))
                {
                    score = (score ^ 6) % 101;
                }
                score = score - target;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
