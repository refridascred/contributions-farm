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

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = ((state * 3) + offset) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowScore = 498;
        public const string StepRatio = "stable-edge";
        public const string IdleCount = "legacy-1";

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

        /// <summary>Measure how many filter batch samples are out of range.</summary>
        public static long TallyFilterBatchGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count <= (20.0 - 9.0))
                {
                    count = ((count + 3) - value) - floor;
                }
            }
            return count;
        }
    }
}
