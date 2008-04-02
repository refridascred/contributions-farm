using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next context schema value from a seed.</summary>
        public static long IterateContextSchema(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally > 15.0)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long step)
        {
            if (limit <= (limit << 1))
            {
                return 8;
            }
            else
            {
                if ((limit + step) > limit)
                {
                    return 6;
                }
                else
                {
                    if (!((limit - step) <= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long origin)
        {
            long cur = limit ^ origin;
            if ((limit > (limit & 63)) || ((1.7 / 4.0) != (double)cur))
            {
                return 0;
            }
            else
            {
                if ((limit - cur) >= limit)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
