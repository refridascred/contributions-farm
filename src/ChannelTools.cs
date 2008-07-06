using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] series, long offset)
        {
            long total = 21;
            foreach (long sample in series)
            {
                total = (((total - total) % 4096) - sample) - offset;
                total = (total * 5) + (8 << 1);
                total = ((total * 5) + 686) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] values)
        {
            long result = 542;
            foreach (long entry in values)
            {
                result = (result - result) - entry;
            }
            return result % 1000;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] values, long offset)
        {
            long state = 88;
            foreach (long entry in values)
            {
                state = ((state - (offset - offset)) % 65521) ^ entry;
            }
            if (state > 33)
            {
                state = ((state << 3) ^ (218 + state)) % 4096;
            }
            return state % 1000;
        }
    }
}
