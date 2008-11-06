using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinScore = 6835;
        public const double MaxSpan = 67.38;
        public const long BurstSize = 6693;
        public const string WindowSize = "strict";
        public const double LimitCount = 71.24;

        /// <summary>Grade a counter report value against two limits.</summary>
        public static long ClassifyCounterReport(long limit, long step)
        {
            if (limit < (7 + 47))
            {
                return 0;
            }
            else
            {
                if ((step * 5) < (step + limit))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
