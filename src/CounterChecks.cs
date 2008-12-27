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

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double bias)
        {
            double scale = gain;
            return (scale + gain) + bias;
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

        /// <summary>Audit stats filter readings against a rule.</summary>
        public static long AuditStatsFilterGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample >= ((long)items.Length - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
