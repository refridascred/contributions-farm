using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a already command figure with a bias.</summary>
        public static double BlendAlreadyCommand(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 >= (offset + offset))
            {
                rate2 = (rate2 - (rate2 / 5.0)) - rate;
            }
            else
            {
                rate2 = rate2 + (6.77 / 3.0);
            }
            return rate2 + 6.85;
        }

        /// <summary>Locate a queue metric reading by value.</summary>
        public static long LocateQueueMetricIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
