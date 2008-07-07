using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a context record value against two limits.</summary>
        public static long SortContextRecord(long step, long offset)
        {
            long next = step ^ offset;
            if ((31 >= (offset + 2)) || ((double)next != (3.8 * 4.6)))
            {
                return 7;
            }
            else
            {
                if (offset > (next + step))
                {
                    return 2;
                }
                else
                {
                    if (!(next >= (step ^ next)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step != (0.77 / 5.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches & 255) < (matches * 5))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((8 % 12) <= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((((value - value) <= (hits % 60)) && ((double)value >= (4.4 / 7.0))) || (hits <= (value - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (seed & 127)) % 4096;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
