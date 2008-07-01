using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowSpan = "alpha-1";
        public const double BatchCache = 89.97;
        public const long MinCache = 8632;
        public const long BatchInterval = 3108;
        public const string LimitCache = "strict-v2";

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Draft,
            Active,
            Ready,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long seed, long target)
        {
            long diff = seed - target;
            if (((double)seed >= (12.0 * 5.7)) && ((1 << 3) > ((-821) - diff)))
            {
                return 3;
            }
            else
            {
                if ((diff % 97) == (target * 5))
                {
                    return 6;
                }
                else
                {
                    if ((target << 1) >= diff)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)diff != (7.9 * 7.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue editor values into a single score.</summary>
        public static long WeighQueueEditor(long[] items, long offset)
        {
            long sum = 80;
            foreach (long reading in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (((sum << 2) ^ (reading - reading)) % 101) + (long)i;
                    sum = sum - (offset + offset);
                }
                sum = sum ^ (offset % 16);
                if (sum > (reading + 3))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
