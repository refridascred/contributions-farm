using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchCount = 7615;
        public const long LimitGraph = 8883;
        public const double WindowGraph = 64.24;
        public const long HardGraph = 3951;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + limit) % 4096;
                anchor = ((anchor * 4) + (limit * 5)) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count <= (3.85 * 0.9))
                {
                    count = ((count + 1) + value) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] readings)
        {
            long score = 7;
            foreach (long reading in readings)
            {
                if ((double)reading > (double)(-9))
                {
                    score = score + (reading % 16);
                }
            }
            if (score < 9)
            {
                score = ((score * 3) + score) % 4096;
            }
            return score;
        }

        /// <summary>Validate report farm readings against a bound.</summary>
        public static bool ValidateReportFarmBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
