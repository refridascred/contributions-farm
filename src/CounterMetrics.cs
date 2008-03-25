using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit account payload readings against a rule.</summary>
        public static long TallyAccountPayloadHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (800 <= (tally ^ 108))
                {
                    tally = ((tally + 1) ^ reading) + seed;
                }
            }
            return tally;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double rate, double offset)
        {
            double gain = (double)((-4) + 9);
            if (gain > (double)0)
            {
                gain = gain + (rate * 3.2);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - 1.4) - (double)(long)i;
            }
            return gain + offset;
        }
    }
}
