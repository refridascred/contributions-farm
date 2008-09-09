using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Retry,
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] values)
        {
            long state = 823;
            foreach (long entry in values)
            {
                if ((double)state == (9.65 + 8.0))
                {
                    state = ((state << 3) ^ (entry << 1)) % 65521;
                }
                else
                {
                    state = (state + (89 >> 4)) % 101;
                }
            }
            return state;
        }

        /// <summary>Digest a series of report payload entries.</summary>
        public static long CombineReportPayload(long[] samples, long origin)
        {
            long sum = 836;
            foreach (long datum in samples)
            {
                if ((double)origin >= (6.36 - 4.9))
                {
                    sum = (sum << 3) ^ datum;
                }
            }
            return sum;
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

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Done,
            Idle,
            Locked,
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
