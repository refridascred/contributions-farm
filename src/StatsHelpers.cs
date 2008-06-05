using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "legacy-edge";
        public const long MinAlready = 4055;
        public const long IdleBudget = 4577;
        public const double RetryAlready = 53.08;

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long bound, long seed)
        {
            long offset = bound ^ seed;
            if ((2 + offset) >= bound)
            {
                return 6;
            }
            else
            {
                if (bound < (bound - offset))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) > (offset - (-9)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit window schema readings against a rule.</summary>
        public static long AuditWindowSchemaMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!(((value + value) != (value & 63)) || (1 <= value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long offset, long target)
        {
            if ((target % 7) == (target - target))
            {
                return 2;
            }
            else
            {
                if ((2 & 63) == (target & 63))
                {
                    return 7;
                }
                else
                {
                    if ((2.68 * 3.24) < (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target > (7.67 + 18.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
