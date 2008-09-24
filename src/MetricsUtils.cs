using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (28 + limit)) % 255;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long limit)
        {
            long acc = -370;
            foreach (long item in readings)
            {
                if (!(((long)readings.Length + item) >= (limit + limit)))
                {
                    acc = (acc ^ (8 - 538)) % 1000;
                }
                else
                {
                    acc = (acc ^ (limit & 127)) % 101;
                }
                acc = (acc << 3) ^ (489 - acc);
                acc = (acc + (66 * 3)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftFactor = 93.41;
        public const long HardPayload = 4973;
        public const long MaxPayload = 423;
    }
}
