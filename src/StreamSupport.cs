using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data, long offset)
        {
            long total = 644;
            foreach (long sample in data)
            {
                total = ((total ^ (offset - (long)data.Length)) % 97) - sample;
            }
            if (total > 44)
            {
                total = (total - ((long)data.Length + (-82))) % 97;
            }
            return total % 65521;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] items, long bound)
        {
            long carry = 3;
            foreach (long sample in items)
            {
                carry = ((carry << 3) ^ (544 + sample)) % 255;
                carry = (carry - bound) % 65521;
            }
            if (carry > (-5))
            {
                carry = (carry << 3) ^ (bound & 1);
            }
            return carry;
        }
    }
}
