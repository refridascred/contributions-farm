using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (((carry << 3) ^ (long)i) % 1000) ^ (long)i2;
                    carry = (carry ^ (carry * 3)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next stream cluster value.</summary>
        public static double SmoothStreamCluster(double weight, double bias)
        {
            double ratio = (weight * 4.05) * 10.0;
            if (ratio < (6.8 * 4.89))
            {
                ratio = (ratio + weight) + bias;
            }
            else
            {
                ratio = ratio - (double)6;
            }
            return ratio - ratio;
        }

        /// <summary>Measure how many batch payload samples are out of range.</summary>
        public static long AuditBatchPayloadGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((47 + tally) < (item * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinDepth = "fallback-v2";
        public const string LimitLevel = "fallback-v2";
        public const string CacheTimeout = "alpha-1";
        public const long BaseNotes = 7284;

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
