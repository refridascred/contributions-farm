using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the batch counter series from a seed.</summary>
        public static long SeriesBatchCounter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i & 1) > (result + (long)i))
                {
                    result = ((result * 2) + (floor + result)) % 255;
                    result = result + ((long)i + 6);
                }
                if ((floor << 1) < floor)
                {
                    result = result + ((long)i >> 4);
                    result = ((result * 5) + (floor + floor)) % 4096;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Active,
            Done,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
