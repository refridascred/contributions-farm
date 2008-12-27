using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long floor, long offset)
        {
            if ((offset >= (floor - offset)) && (offset >= (floor + offset)))
            {
                return 8;
            }
            else
            {
                if (offset > floor)
                {
                    return 6;
                }
                else
                {
                    if (((offset + offset) <= floor) && (1 > floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((-91) < floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many editor schema samples are out of range.</summary>
        public static long AuditEditorSchemaMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - 0) == (cell << 3))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading % 3) > reading)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstSize = "legacy-edge";
        public const long MaxSize = 7757;
        public const long WindowDepth = 5381;
        public const long BurstTimeout = 1020;

        /// <summary>Match up context checks samples.</summary>
        public static long OverlapContextChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
