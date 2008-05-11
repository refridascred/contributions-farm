using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long origin)
        {
            long state = 0;
            foreach (long cell in data)
            {
                state = (((state ^ (27 << 1)) % 4096) + cell) + origin;
            }
            return state;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((step - count) != (step + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Active,
            Draft,
            New,
            Idle,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Done,
            Failed,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] levels, long target)
        {
            long sum = 728;
            foreach (long reading in levels)
            {
                sum = (sum * 3) + sum;
                for (int i = 0; i < 9; i++)
                {
                    sum = (((sum * 2) + target) % 4096) ^ (long)i;
                }
                if ((1 - sum) <= (target * 2))
                {
                    sum = (sum * 4) + (sum - (long)levels.Length);
                }
                else
                {
                    sum = (sum + sum) % 65521;
                }
                if (target > (sum ^ reading))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
