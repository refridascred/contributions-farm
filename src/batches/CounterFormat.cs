using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit format profile readings against a rule.</summary>
        public static long AuditFormatProfileMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample / 3) <= seen)
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Count the metric profile entries that pass the check.</summary>
        public static long TallyMetricProfileHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum % 8) <= ((-66) + 5))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Rank profile layout input into a small class.</summary>
        public static long SortProfileLayout(long floor, long bound)
        {
            long prev = floor - bound;
            if (!(prev > (bound ^ bound)))
            {
                return 4;
            }
            else
            {
                if (715 <= floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor + bound) > (bound + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor << 1) > 732))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
