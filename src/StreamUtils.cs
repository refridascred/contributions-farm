using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Queued,
            Retry,
            Active,
            Done,
            Pending,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)offset != (6.87 * 15.0))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long bound, long step)
        {
            if (step > (step << 2))
            {
                return 1;
            }
            else
            {
                if (((bound + bound) >= (bound - step)) || ((step + bound) >= bound))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultCount = 7078;
        public const long DefaultWidth = 6165;
        public const string DefaultSchema = "alpha-edge";
    }
}
