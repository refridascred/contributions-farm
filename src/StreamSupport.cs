using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate channel already samples.</summary>
        public static long TallyChannelAlready(long[] samples, long seed)
        {
            long total = 0;
            foreach (long value in samples)
            {
                total = ((total + (value - total)) % 4096) + seed;
                if ((total >> 1) < (value * 3))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] values, long target)
        {
            long result = 530;
            foreach (long cell in values)
            {
                if ((long)values.Length < (target >> 2))
                {
                    result = ((result - (result & 1)) % 65521) - cell;
                }
                else
                {
                    result = (result + 12) % 4096;
                }
            }
            return result;
        }
    }
}
