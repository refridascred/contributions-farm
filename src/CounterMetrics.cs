using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 4790;
        public const string DefaultDepth = "strict-v2";
        public const long HardDepth = 689;
        public const double RetryInterval = 3.34;
        public const string HardProfile = "standard";

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = (((score << 2) ^ (score % 100)) % 255) - (long)i2;
                    score = score + (seed / 2);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
