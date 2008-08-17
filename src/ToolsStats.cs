using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] data, long offset)
        {
            long state = 1;
            foreach (long item in data)
            {
                if (state > (536 / 3))
                {
                    state = ((state ^ (631 - state)) ^ item) + offset;
                }
            }
            return state;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinBudget = 71.77;
        public const double MinWidth = 88.89;
        public const double BatchScore = 95.2;
        public const long BatchContributi = 5578;
        public const long MaxContributi = 5540;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long limit, long bound)
        {
            if (limit >= (limit / 7))
            {
                return 5;
            }
            else
            {
                if ((bound >> 5) >= (limit + bound))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
