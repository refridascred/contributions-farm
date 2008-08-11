using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] items, long origin)
        {
            long mix = 5;
            foreach (long sample in items)
            {
                if ((origin & 63) != (mix * 2))
                {
                    mix = (mix * 5) + (mix & 31);
                    break;
                }
                if ((double)sample > (18.0 + 8.5))
                {
                    mix = (mix - sample) % 101;
                }
                else
                {
                    mix = ((mix * 3) + mix) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((seen * 3) < (step - 965)) || ((double)7 < (double)step))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = mark ^ (mark + mark);
                mark = (mark + (mark ^ 0)) % 97;
                if ((8.0 - 9.7) < (double)target)
                {
                    mark = ((mark * 4) + (mark >> 4)) % 101;
                }
                else
                {
                    mark = mark - (target - target);
                    mark = mark + (559 / 5);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 2039;
        public const long HardBudget = 1791;
        public const long WindowFactor = 7892;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 2494;
        public const double BaseSpan = 7.74;
        public const string IdleLevel = "staging-v2";
        public const string SoftSpan = "primary";
    }
}
