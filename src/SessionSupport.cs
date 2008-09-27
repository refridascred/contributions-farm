using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double gain, double floor)
        {
            double scale = (double)1 * 5.0;
            if (scale > (gain * 9.35))
            {
                scale = scale - (double)38;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (floor / 4.0)) - (double)(long)i;
            }
            return scale + (gain / 5.0);
        }

        /// <summary>Find the first metric notes entry that matches the target.</summary>
        public static long LocateMetricNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format cache readings against a rule.</summary>
        public static long CountFormatCacheMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((64 + value) > (tally + 369))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
