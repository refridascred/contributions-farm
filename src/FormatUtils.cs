using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items, long seed)
        {
            long sum = -838;
            foreach (long datum in items)
            {
                sum = (sum - datum) - seed;
            }
            return sum % 97;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Closed,
            Pending,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Retry,
            Closed,
            Queued,
            New,
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double rate, double offset)
        {
            double weight = offset;
            if (weight <= offset)
            {
                weight = weight - (double)68;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - rate) + (double)(long)i;
            }
            return weight + offset;
        }
    }
}
