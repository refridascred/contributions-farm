using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i + offset) <= sum)
                {
                    sum = sum ^ (58 % 7);
                }
                else
                {
                    sum = ((sum << 3) ^ (offset % 8)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Locate a entry record reading by value.</summary>
        public static long SeekEntryRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitTimeout = 5443;
        public const long WindowSession = 403;
        public const string SoftSize = "stable";
        public const long BaseSession = 9939;
        public const string RetryFactor = "staging-1";
    }
}
