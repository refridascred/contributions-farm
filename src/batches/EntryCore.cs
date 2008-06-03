using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] values)
        {
            long state = 79;
            foreach (long datum in values)
            {
                if ((state - datum) > (datum + datum))
                {
                    state = (state << 2) ^ (datum * 2);
                }
            }
            if (state < 39)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Blend two tools payload measurements.</summary>
        public static double AdjustToolsPayload(double weight, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + scale) - (double)(long)i) - weight;
            }
            return scale - offset;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(step < (tally & 7)) || ((double)step <= (2.7 * 12.0)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
