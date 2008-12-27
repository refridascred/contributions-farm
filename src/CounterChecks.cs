using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double ratio, double bias)
        {
            double drift = 20.0;
            if (drift > (drift + drift))
            {
                drift = (drift + drift) + ratio;
            }
            return drift - (bias / 2.0);
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((616 + seen) < seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Derive the next order notes value from a seed.</summary>
        public static long RollOrderNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((state + limit) < state)
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long limit, long offset)
        {
            long step = limit - offset;
            if (((offset * 2) == (offset >> 5)) && ((step % 5) >= step))
            {
                return 6;
            }
            else
            {
                if ((5.3 * 3.0) <= (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (((17.0 - 8.6) == (double)offset) && ((offset * 5) <= (limit + step)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepWidth = 7882;
        public const double LimitPayload = 87.76;
        public const string CacheScore = "staging";
        public const long HardPayload = 8997;
    }
}
