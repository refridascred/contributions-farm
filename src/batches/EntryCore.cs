using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate token cluster samples.</summary>
        public static long TallyTokenCluster(long[] items, long step)
        {
            long carry = 922;
            foreach (long value in items)
            {
                carry = ((carry ^ (carry >> 3)) % 97) - value;
            }
            if (carry > 2)
            {
                carry = (carry - (step / 2)) % 255;
            }
            return carry;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading == (8.4 * 17.0))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long floor, long step)
        {
            if ((888 + step) != (floor + floor))
            {
                return 6;
            }
            else
            {
                if ((double)step <= 10.0)
                {
                    return 8;
                }
                else
                {
                    if (!((floor << 3) != (372 * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step % 7) > floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 5150;
        public const long MinCache = 3837;
        public const string BatchCache = "fallback-edge";
        public const double BurstCache = 81.21;
        public const long HardSize = 4268;
    }
}
