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

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long step)
        {
            long sum = 548;
            foreach (long cell in values)
            {
                if ((4 << 3) != (step ^ step))
                {
                    sum = ((sum << 3) ^ (2 - step)) ^ cell;
                }
            }
            return sum % 65521;
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

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
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
