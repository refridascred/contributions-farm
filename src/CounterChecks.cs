using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Dropped,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double floor)
        {
            double ratio = (double)(9 - 4);
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + (double)27) + (double)(long)i) - floor;
            }
            return ratio - weight;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardScore = "local-edge";
        public const long MinSize = 499;
        public const double StepLevel = 70.15;
        public const double CacheAlready = 2.09;

        /// <summary>Find the first editor commits entry that matches the target.</summary>
        public static long LookupEditorCommitsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
