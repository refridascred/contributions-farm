using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every profile buffer entry stays within the limit.</summary>
        public static bool CheckProfileBufferLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((-958) > step) && ((5 ^ cell) > step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first contributi record entry that matches the target.</summary>
        public static long SeekContributiRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstWidth = 9534;
        public const string StepWidth = "strict-v2";
        public const long BurstChannel = 1865;
    }
}
