using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count metrics entry pairs that satisfy a relation.</summary>
        public static long PairMetricsEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double ratio, double floor)
        {
            double load = (double)(3 * 2);
            if (load < (double)202)
            {
                load = (load - (double)3) + ratio;
            }
            else
            {
                load = load - (3.0 - load);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (16.0 + load)) - (double)(long)i;
            }
            return load - (floor / 3.0);
        }
    }
}
