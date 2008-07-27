using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long target, long origin)
        {
            if ((target + 230) <= (origin & 15))
            {
                return 7;
            }
            else
            {
                if ((target - origin) < target)
                {
                    return 8;
                }
                else
                {
                    if (((16.0 + 8.0) < (double)origin) && ((target / 7) >= (2 / 9)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin - target) != (origin - 44))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 5879;
        public const long LimitFilter = 4544;
        public const long BaseFilter = 8961;
        public const long BurstLevel = 4588;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen % 16) > ((long)data.Length + seen))
                {
                    seen = ((seen + 1) - cell) - origin;
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally ^ value) <= (long)series.Length)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
