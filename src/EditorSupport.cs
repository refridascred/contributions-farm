using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit batches window readings against a rule.</summary>
        public static long TallyBatchesWindowMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (target < (count - count))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = score + (long)i;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((count - datum) > (datum << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the contributi channel series from a seed.</summary>
        public static long IterateContributiChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                long bound = (carry & 127) + (target + carry);
                if ((double)(long)i <= (11.0 / 7.0))
                {
                    carry = carry + bound;
                }
                else
                {
                    carry = (carry + (target - (long)i)) % 255;
                    bound = ((bound * 5) + target) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Stale,
            Ready,
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value != (4.0 / 7.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
