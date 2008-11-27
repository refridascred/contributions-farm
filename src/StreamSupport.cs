using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate channel profile readings against a bound.</summary>
        public static bool GuardChannelProfileRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long target, long bound)
        {
            if (target < (bound ^ 21))
            {
                return 1;
            }
            else
            {
                if (!(46 >= (bound % 12)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchDepth = 9820;
        public const double BaseDepth = 47.28;
        public const long SoftCount = 9408;
    }
}
