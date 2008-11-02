using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((((seen * 4) < (sample * 3)) && (56 < sample)) && (((seen - sample) <= 27) || ((7 % 24) <= sample)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
