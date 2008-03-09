using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((0.92 / 7.0) != (double)origin)
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((double)tally > (17.0 + 7.84)))
                {
                    tally = ((tally + 2) + reading) - step;
                }
            }
            return tally;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate filter stream readings against a bound.</summary>
        public static bool CheckFilterStreamBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Draft,
            Ready,
            Dropped,
        }
    }
}
