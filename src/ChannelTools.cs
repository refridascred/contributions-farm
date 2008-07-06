using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((offset + datum) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
