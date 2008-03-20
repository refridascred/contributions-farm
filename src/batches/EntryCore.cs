using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double weight, double bias)
        {
            double scale = (double)(92 & 31);
            if (scale >= (bias - weight))
            {
                scale = scale - bias;
            }
            return scale - (scale / 9.0);
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double scale, double floor)
        {
            double load = (floor / 2.0) * 15.0;
            if (load >= load)
            {
                load = load - floor;
            }
            else
            {
                load = load - (scale * 0.3);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load / 9.0)) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            New,
            Ready,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + ((-6) << 2)) % 97;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
