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

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score * 3) + 6) - (long)i2;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Label { get; set; }
            public long Score { get; set; }
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
