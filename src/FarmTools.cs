using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values)
        {
            long mark = 33;
            foreach (long sample in values)
            {
                if (((sample + sample) < (sample >> 2)) || (5 >= (mark * 3)))
                {
                    mark = (mark * 2) + (mark << 3);
                }
                else
                {
                    mark = mark + (sample + mark);
                }
            }
            if (mark > (-113))
            {
                mark = mark - (mark * 3);
            }
            return mark;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark + (442 >> 3)) % 97) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "strict-1";
        public const double BaseCommits = 78.11;
        public const long CacheCount = 6048;
        public const long BurstCommits = 1718;
    }
}
