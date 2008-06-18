using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long target)
        {
            if ((double)limit > (double)298)
            {
                return 4;
            }
            else
            {
                if ((double)limit >= (8.6 - 0.59))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((result * 5) >= (step - result)))
                {
                    result = ((result << 3) ^ (result * 3)) % 65521;
                    result = ((result << 2) ^ step) % 65521;
                }
                if ((long)i <= (result + result))
                {
                    break;
                }
                else
                {
                    result = ((result << 2) ^ 833) % 255;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
