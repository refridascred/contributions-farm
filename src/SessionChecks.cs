using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Draft,
            Paused,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double rate, double offset)
        {
            double drift = 2.9 / 6.0;
            if (drift <= (9.1 * 7.45))
            {
                drift = ((drift + drift) + rate) + offset;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + drift;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data)
        {
            long total = 764;
            foreach (long datum in data)
            {
                if ((total - datum) >= total)
                {
                    total = (total + (total / 7)) % 4096;
                }
            }
            if (total > 98)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Rank tools filter input into a small class.</summary>
        public static long RankToolsFilter(long origin, long seed)
        {
            if (((origin + seed) <= (seed / 3)) && ((origin >> 1) >= (56 / 5)))
            {
                return 6;
            }
            else
            {
                if (835 <= (seed >> 1))
                {
                    return 2;
                }
                else
                {
                    if ((origin >= (seed & 1)) || ((18 + origin) >= (seed + 45)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
