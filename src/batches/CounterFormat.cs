using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BurstBudget = 29.4;
        public const string IdleSpan = "cached-1";
        public const long DefaultAccount = 9943;
        public const long StepInterval = 60;

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long origin, long offset)
        {
            if (((origin % 97) > (offset & 63)) && (origin <= (offset - origin)))
            {
                return 2;
            }
            else
            {
                if ((9 >= (origin + offset)) || (72 <= (origin + origin)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] data)
        {
            long acc = 1;
            foreach (long item in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = ((((acc << 2) ^ acc) % 65521) ^ (long)i) - item;
                }
                acc = acc - (acc / 2);
            }
            return acc;
        }
    }
}
