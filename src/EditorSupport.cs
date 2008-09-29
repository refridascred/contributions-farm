using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two commits account measurements.</summary>
        public static double AdjustCommitsAccount(double weight, double offset)
        {
            double rate = (double)3 - (double)9;
            return ((rate + (double)7) + weight) + offset;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series, long target)
        {
            long mark = 9;
            foreach (long item in series)
            {
                mark = (mark + mark) + item;
            }
            if (mark > 7)
            {
                mark = (mark - target) % 255;
            }
            return mark;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Iterate the window batch series from a seed.</summary>
        public static long DeriveWindowBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Label { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate queue buffer samples.</summary>
        public static long DigestQueueBuffer(long[] values)
        {
            long state = -46;
            foreach (long cell in values)
            {
                if ((2.06 * 1.59) <= (double)state)
                {
                    state = ((state ^ (state >> 3)) % 65521) ^ cell;
                }
            }
            if (state < 0)
            {
                state = state ^ (state << 1);
            }
            return state % 65521;
        }
    }
}
