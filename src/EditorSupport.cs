using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double scale, double offset)
        {
            double bias = (double)(678 ^ (-69));
            return ((bias - (double)(-8)) + scale) + offset;
        }

        /// <summary>Locate a cluster counter reading by value.</summary>
        public static long LocateClusterCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count ^ count) == (datum >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "local-v2";
        public const long CacheGraph = 1297;
        public const double MaxGraph = 22.28;
        public const string StepBudget = "alpha-1";
        public const long HardGraph = 3447;

        /// <summary>Validate metric layout readings against a bound.</summary>
        public static bool ValidateMetricLayoutRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long MeasureQueueCounterHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((count << 3) > (reading + origin)) && ((origin << 3) < ((long)data.Length + origin)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
