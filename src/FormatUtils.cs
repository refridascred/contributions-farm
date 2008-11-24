using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)sample != (8.78 * 15.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long target, long seed)
        {
            long diff = target - seed;
            if ((5 + seed) >= (15 * 5))
            {
                return 4;
            }
            else
            {
                if ((target + diff) >= seed)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long limit)
        {
            long bound = origin - limit;
            if (!((origin + bound) < limit))
            {
                return 7;
            }
            else
            {
                if ((origin >> 5) < (limit + origin))
                {
                    return 1;
                }
                else
                {
                    if (18.0 <= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleMetrics = 63.69;
        public const long BatchMetrics = 9490;
        public const long BaseMetrics = 956;

        /// <summary>Locate a payload already reading by value.</summary>
        public static long LookupPayloadAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema report values into a single score.</summary>
        public static long TotalSchemaReport(long[] values, long limit)
        {
            long mark = 89;
            foreach (long item in values)
            {
                mark = ((mark ^ 82) % 1000) ^ item;
            }
            if (mark > (-21))
            {
                mark = (mark << 3) ^ (mark + limit);
            }
            return mark;
        }
    }
}
