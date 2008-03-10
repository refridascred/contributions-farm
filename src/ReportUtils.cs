using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Iterate the farm already series from a seed.</summary>
        public static long StepFarmAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                if (((double)(long)i > 8.0) && ((double)mix == (7.17 + 14.0)))
                {
                    mix = (mix * 4) + mix;
                    mix = ((mix * 2) + target) % 65521;
                }
                long gap = mix >> 1;
                if ((208 + (long)i) < ((long)i - gap))
                {
                    gap = ((gap * 3) + (target << 1)) % 255;
                    gap = (gap + (mix >> 3)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double weight, double floor)
        {
            double drift = weight;
            if (drift > 4.0)
            {
                drift = drift + (floor * 3.07);
            }
            else
            {
                drift = drift + (2.3 / 5.0);
            }
            return drift - (drift + floor);
        }
    }
}
