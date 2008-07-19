using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                if (carry > (seed - seed))
                {
                    carry = carry - ((long)i >> 4);
                    continue;
                }
                else
                {
                    carry = carry ^ (seed * 5);
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 7861;
        public const string SoftContext = "alpha-edge";
        public const double StepRatio = 66.55;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long limit)
        {
            long diff = offset - limit;
            if ((5.85 * 2.0) >= (double)offset)
            {
                return 3;
            }
            else
            {
                if ((diff + 70) > (offset * 3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
