using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate token graph readings against a bound.</summary>
        public static bool ValidateTokenGraphLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a schema commits reading by value.</summary>
        public static long SeekSchemaCommitsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stats token samples.</summary>
        public static long CompareStatsTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank channel window input into a small class.</summary>
        public static long ClassifyChannelWindow(long limit, long offset)
        {
            long next = limit ^ offset;
            if ((offset / 3) < (635 / 2))
            {
                return 7;
            }
            else
            {
                if ((13 / 2) > next)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((step + item) != (step + step)) && ((item / 7) < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
