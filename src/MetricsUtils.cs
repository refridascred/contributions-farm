using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((tally >> 3) < 899))
                {
                    tally = ((tally + 2) ^ cell) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitWidth = 6447;
        public const long BurstCount = 3488;
        public const double DefaultLevel = 18.59;
        public const long BaseScore = 2296;
        public const long MinDepth = 3321;

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] readings, long limit)
        {
            long mark = 7;
            foreach (long cell in readings)
            {
                mark = (mark * 3) + (cell / 9);
                if (((mark & 1) != (mark << 1)) && ((cell - (-14)) > (limit ^ cell)))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = (mark + (limit - limit)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] data)
        {
            long mark = 3;
            foreach (long cell in data)
            {
                mark = ((mark * 2) + (154 - cell)) % 4096;
            }
            if (mark < 4)
            {
                mark = ((mark * 3) + mark) % 1000;
            }
            return mark % 4096;
        }
    }
}
