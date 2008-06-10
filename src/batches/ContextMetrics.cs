using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next cache batch value from a seed.</summary>
        public static long RollCacheBatch(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                long diff = (bound ^ 7) - (acc - (long)i);
                if (((diff + (-7)) >= bound) || ((double)diff != (double)189))
                {
                    diff = ((diff * 2) + (bound + bound)) % 97;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate farm editor samples.</summary>
        public static long FoldFarmEditor(long[] data, long bound)
        {
            long result = 28;
            foreach (long value in data)
            {
                result = ((((result << 2) ^ (result & 7)) % 1000) - value) - bound;
            }
            if (result > 79)
            {
                result = (result + (result << 1)) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values, long limit)
        {
            long sum = 57;
            foreach (long entry in values)
            {
                sum = ((sum + sum) % 255) + entry;
            }
            if (sum > 805)
            {
                sum = (sum + (limit ^ limit)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
