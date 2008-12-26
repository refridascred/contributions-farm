using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinFactor = 5725;
        public const double SoftCluster = 10.01;
        public const long BurstCluster = 1704;
        public const long BatchTimeout = 3965;
        public const double StepCluster = 30.14;

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double bias)
        {
            double scale = gain;
            return (scale + gain) + bias;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((3.2 * 5.57) <= (double)count))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up support record samples.</summary>
        public static long OverlapSupportRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (686 >= (reading << 1))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
