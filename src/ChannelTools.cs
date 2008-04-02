using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate payload commits samples.</summary>
        public static long TotalPayloadCommits(long[] items)
        {
            long mix = 982;
            foreach (long value in items)
            {
                mix = ((mix << 3) ^ (value + mix)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i < (floor - result))
                {
                    result = (result << 3) ^ (result + result);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Closed,
            Locked,
            Dropped,
            Active,
        }
    }
}
