using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many schema record samples are out of range.</summary>
        public static long AuditSchemaRecordMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((offset * 4) <= (hits & 3))
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a already schema pair into a bucket.</summary>
        public static long SortAlreadySchema(long limit, long target)
        {
            if ((5.04 + 1.6) < (double)limit)
            {
                return 0;
            }
            else
            {
                if ((double)target >= 8.7)
                {
                    return 8;
                }
                else
                {
                    if (target >= (limit + (-597)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up schema notes samples.</summary>
        public static long OverlapSchemaNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 7247;
        public const string StepSize = "standard-v2";
        public const long HardChannel = 2485;
        public const double LimitChannel = 37.62;
        public const string CacheTimeout = "local-v2";
    }
}
