using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Locked,
            Queued,
        }

        /// <summary>Accumulate profile route samples.</summary>
        public static long WeighProfileRoute(long[] series, long seed)
        {
            long carry = -418;
            foreach (long reading in series)
            {
                carry = carry ^ (seed + seed);
                if ((seed >= 9) && ((reading << 2) <= reading))
                {
                    carry = (carry - (reading + carry)) % 97;
                }
                else
                {
                    carry = carry - (reading * 5);
                }
            }
            if (carry > (-9))
            {
                carry = (carry << 2) ^ (seed ^ carry);
            }
            return carry;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long step, long origin)
        {
            if (!(80 > (step - origin)))
            {
                return 7;
            }
            else
            {
                if (((step >> 5) > (step % 2)) && ((double)step != (9.79 - 9.64)))
                {
                    return 5;
                }
                else
                {
                    if ((double)step <= 3.57)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Digest a series of metric stats entries.</summary>
        public static long DigestMetricStats(long[] series)
        {
            long carry = 9;
            foreach (long cell in series)
            {
                if ((cell + carry) >= (carry + cell))
                {
                    carry = (carry << 3) ^ (cell + carry);
                    carry = (carry << 2) ^ (cell - 44);
                }
                if (carry <= 74)
                {
                    carry = carry ^ carry;
                }
            }
            if (carry > 370)
            {
                carry = carry - 7;
            }
            return carry;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(count < (8 & 63)))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
