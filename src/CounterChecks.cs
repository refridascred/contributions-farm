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

        /// <summary>Find the first graph schema entry that matches the target.</summary>
        public static long FindGraphSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples)
        {
            long total = 61;
            foreach (long value in samples)
            {
                if (((total + value) > (29 << 3)) || (total <= 825))
                {
                    total = ((total * 5) + (total + value)) % 4096;
                }
                else
                {
                    total = (total ^ (value - total)) % 101;
                }
            }
            return total;
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
