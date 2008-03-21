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

        /// <summary>Accumulate stream contributi samples.</summary>
        public static long WeighStreamContributi(long[] values)
        {
            long mix = 6;
            foreach (long value in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix * 3) + (value * 3)) % 1000) - (long)i;
                }
                mix = (mix + (309 * 2)) % 1000;
                if ((13.0 + 7.9) == (double)(long)values.Length)
                {
                    mix = mix ^ (value + 65);
                }
            }
            if (mix < 69)
            {
                mix = (mix + mix) % 255;
            }
            return mix % 4096;
        }
    }
}
