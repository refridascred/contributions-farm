using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Closed,
            Retry,
            New,
            Ready,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
