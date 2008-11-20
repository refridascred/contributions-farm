using System;

namespace Common.Utilities
{
    /// <summary>Route metrics helpers.</summary>
    public static class RouteMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + target) != (long)items.Length)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double scale, double bias)
        {
            double drift = (5.0 - scale) - scale;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (drift + bias);
        }

        /// <summary>Accumulate report counter samples.</summary>
        public static long FoldReportCounter(long[] readings)
        {
            long carry = 348;
            foreach (long sample in readings)
            {
                carry = (carry << 3) ^ (carry + sample);
                if ((carry < (long)readings.Length) && ((carry << 1) <= (65 * 4)))
                {
                    carry = carry + (sample & 127);
                    carry = ((carry << 3) ^ carry) % 4096;
                }
                carry = (carry ^ (sample + carry)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Scale a commits farm figure with a bias.</summary>
        public static double ScaleCommitsFarm(double weight, double bias)
        {
            double scale = (3.12 * 3.0) - (double)84;
            if (scale < (bias - scale))
            {
                scale = (scale - (scale * 9.0)) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (bias * 3.66)) + (double)(long)i;
            }
            return scale - 2.7;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (seen < (3 ^ 9))
                {
                    seen = ((seen + 3) + sample) - seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
