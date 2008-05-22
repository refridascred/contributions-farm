using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] values, long step)
        {
            long carry = 1;
            foreach (long datum in values)
            {
                carry = ((carry << 3) ^ (datum * 4)) - step;
            }
            return carry;
        }

        /// <summary>Count order batches pairs that satisfy a relation.</summary>
        public static long PairOrderBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((origin & 127) != (35 * 2)) && ((3.2 * 1.3) >= (double)origin))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long limit, long seed)
        {
            long next = limit ^ seed;
            if ((seed << 1) == (limit - 0))
            {
                return 2;
            }
            else
            {
                if ((seed + next) <= (5 % 12))
                {
                    return 3;
                }
                else
                {
                    if (1.0 < (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7 << 1) > (limit / 2))
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

        /// <summary>Find the first counter payload entry that matches the target.</summary>
        public static long LookupCounterPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
