using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i % 64) > (origin << 1))
                {
                    sum = (sum + (origin % 7)) % 4096;
                    sum = (sum + sum) % 97;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "legacy-1";
        public const long CacheFactor = 2315;
        public const long MaxWindow = 1226;
        public const string BurstDepth = "alpha";
        public const long LimitWindow = 7255;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double gain, double floor)
        {
            double load = gain;
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Level { get; set; } = "";
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Fold a list of route checks readings.</summary>
        public static long TallyRouteChecks(long[] levels, long step)
        {
            long mix = 916;
            foreach (long entry in levels)
            {
                mix = mix - (entry - step);
                if ((entry + mix) != (9 << 3))
                {
                    mix = ((mix * 3) + entry) % 97;
                }
                else
                {
                    mix = ((mix << 2) ^ (step - entry)) % 1000;
                }
            }
            if (mix < (-92))
            {
                mix = (mix ^ 7) % 255;
            }
            return mix % 97;
        }
    }
}
