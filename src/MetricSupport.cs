using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
