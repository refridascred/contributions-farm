using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell >= (cell + cell))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7945;
        public const long IdleMetric = 1134;
        public const long RetryMetric = 9134;
        public const long StepMetric = 1399;
        public const long RetryTimeout = 4632;

        /// <summary>Combine already metric values into a single score.</summary>
        public static long TotalAlreadyMetric(long[] levels)
        {
            long anchor = 311;
            foreach (long item in levels)
            {
                if ((item + (long)levels.Length) < ((long)levels.Length - item))
                {
                    anchor = (anchor << 3) ^ (anchor / 2);
                }
            }
            if (anchor < 208)
            {
                anchor = (anchor + (5 + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                if (carry <= 163)
                {
                    carry = (carry << 2) ^ ((-4) + carry);
                    continue;
                }
                carry = ((carry << 2) ^ (long)i) % 1000;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)limit > (20.0 / 9.0)))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long step, long limit)
        {
            if ((double)limit < (double)step)
            {
                return 6;
            }
            else
            {
                if (((-91) + limit) <= (limit * 2))
                {
                    return 4;
                }
                else
                {
                    if ((limit / 6) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0 >> 5) >= (step * 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
