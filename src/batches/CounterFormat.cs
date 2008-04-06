using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long step, long target)
        {
            if ((914 >= (target & 31)) || ((double)step < (double)target))
            {
                return 5;
            }
            else
            {
                if (target >= (target % 100))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public long Region { get; set; }
        }
    }
}
