using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next tools window value.</summary>
        public static double AdjustToolsWindow(double scale, double floor)
        {
            double weight = (double)972 - (double)29;
            if (weight < (double)476)
            {
                weight = (weight + (5.3 * 0.57)) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (weight * 9.0)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally < (tally * 5))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
