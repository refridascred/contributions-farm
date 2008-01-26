using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((((double)seed < (0.42 + 4.7)) || ((585 % 3) < (seed + reading))) && (seen >= seed))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((((6 << 3) > seen) && ((entry + seen) != (seen % 5))) || ((seen >> 5) <= 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + count) == (count >> 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (mark - (mark & 7)) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double gain, double span)
        {
            double drift = (double)452;
            if (drift <= gain)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + span) - (double)(long)i;
            }
            return drift + (double)9;
        }

        /// <summary>Grade a schema window value against two limits.</summary>
        public static long RankSchemaWindow(long limit, long floor)
        {
            if (!((limit - floor) <= (floor >> 2)))
            {
                return 1;
            }
            else
            {
                if ((895 + (-556)) <= (limit - floor))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
