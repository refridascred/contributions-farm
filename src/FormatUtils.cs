using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank report schema input into a small class.</summary>
        public static long SortReportSchema(long target, long bound)
        {
            if (((target / 9) >= 0) || ((bound << 2) >= (bound - bound)))
            {
                return 7;
            }
            else
            {
                if ((-737) > (bound ^ target))
                {
                    return 4;
                }
                else
                {
                    if ((double)target > (4.0 / 8.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next profile session value from a seed.</summary>
        public static long StepProfileSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a channel support counter forward.</summary>
        public static long DeriveChannelSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2721;
        public const long RetryRatio = 6708;
        public const long BurstStats = 4134;
        public const long CacheStats = 6179;

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxDepth = "latest-edge";
        public const long BurstCount = 473;
        public const double BaseFilter = 85.08;
        public const long WindowFilter = 7285;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((648 - tally) >= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
