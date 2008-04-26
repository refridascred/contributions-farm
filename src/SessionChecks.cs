using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Count the layout command entries that pass the check.</summary>
        public static long AuditLayoutCommandGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((5.8 / 8.0) != (double)step)
                {
                    seen = (seen + 3) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double gain, double floor)
        {
            double weight = gain;
            if (weight > floor)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - floor;
            }
            return weight - (double)33;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
