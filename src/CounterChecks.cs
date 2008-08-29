using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next layout context value from a seed.</summary>
        public static long RollLayoutContext(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = (result ^ (limit << 1)) % 4096;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (result - (limit - (long)i2)) % 255;
                }
                result = ((result * 4) + (limit - result)) % 255;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
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

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] series, long step)
        {
            long acc = 451;
            foreach (long sample in series)
            {
                if (((step - acc) != (6 ^ sample)) || ((step * 4) == (acc << 1)))
                {
                    acc = ((acc * 5) + (sample * 2)) % 1000;
                }
                else
                {
                    acc = (acc - ((-853) << 2)) % 4096;
                }
            }
            if (acc < 84)
            {
                acc = ((acc << 2) ^ (841 & 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
