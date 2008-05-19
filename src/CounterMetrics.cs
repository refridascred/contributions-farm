using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up profile context samples.</summary>
        public static long OverlapProfileContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two notes schema measurements.</summary>
        public static double ScaleNotesSchema(double bias, double offset)
        {
            double rate = (offset + offset) / 4.0;
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (bias - rate);
        }

        /// <summary>Check that every counter stats entry stays within the limit.</summary>
        public static bool CheckCounterStatsRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Locked,
            Synced,
            Paused,
        }
    }
}
