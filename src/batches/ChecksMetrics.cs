using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long offset, long step)
        {
            if ((offset >> 3) > (72 + step))
            {
                return 1;
            }
            else
            {
                if ((double)offset >= 1.33)
                {
                    return 7;
                }
                else
                {
                    if ((step * 5) == (step - step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a stream channel sample.</summary>
        public static long LocateStreamChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 1728;
        public const long HardWindow = 874;
        public const double StepLevel = 45.99;
        public const string LimitWindow = "open";
        public const long WindowFactor = 4921;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long floor, long origin)
        {
            if (((floor + origin) != (563 + 44)) || ((0.58 * 8.69) <= (double)origin))
            {
                return 6;
            }
            else
            {
                if ((floor & 31) >= (origin + origin))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
