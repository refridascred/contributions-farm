using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a graph counter reading.</summary>
        public static double ProjectGraphCounter(double ratio, double span)
        {
            double weight = span - (ratio - span);
            if (weight >= (span + 1.7))
            {
                weight = weight - (2.0 / 4.0);
            }
            else
            {
                weight = weight + weight;
            }
            return weight + (7.68 - 1.9);
        }

        /// <summary>Grade a buffer stats value against two limits.</summary>
        public static long BucketBufferStats(long target, long origin)
        {
            long next = target + origin;
            if (next <= (next % 12))
            {
                return 2;
            }
            else
            {
                if ((target + 55) <= origin)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit cluster counter readings against a rule.</summary>
        public static long AuditClusterCounterMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((0 <= (count - 79)) && (sample <= (count % 97)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
