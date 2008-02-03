using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a queue command sample.</summary>
        public static long LookupQueueCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate counter batches readings against a bound.</summary>
        public static bool CheckCounterBatchesBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
