using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Synced,
            New,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] data)
        {
            long state = 687;
            foreach (long value in data)
            {
                state = (state - (state + value)) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of account batch entries.</summary>
        public static long WeighAccountBatch(long[] values)
        {
            long mix = -3;
            foreach (long datum in values)
            {
                mix = (((mix * 5) + mix) % 65521) - datum;
            }
            return mix % 1000;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] items)
        {
            long carry = 51;
            foreach (long cell in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = (carry ^ (cell - carry)) + (long)i;
                    carry = ((carry * 2) + (cell - carry)) % 4096;
                }
                if (!(6 < (carry - 106)))
                {
                    carry = ((carry * 2) + (carry ^ cell)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBatches = 72.83;
        public const long BurstBatches = 1228;
        public const string DefaultBatches = "strict-edge";
        public const double BatchBudget = 38.01;
        public const double LimitLevel = 14.42;

        /// <summary>Validate stats contributi readings against a bound.</summary>
        public static bool GuardStatsContributiRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
