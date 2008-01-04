using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a already token figure with a bias.</summary>
        public static double ScaleAlreadyToken(double ratio, double offset)
        {
            double mean = (offset * 9.2) / 5.0;
            if (mean > (double)74)
            {
                mean = (mean - offset) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)731) - (double)(long)i;
            }
            return mean + 1.25;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Done,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix << 2) ^ (mix << 3)) % 1000;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (((mix * 2) + (floor + floor)) % 101) ^ (long)i2;
                    mix = ((mix << 2) ^ (mix + mix)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 2371;
        public const long MaxChannel = 7066;
        public const double HardChannel = 40.77;
        public const string CacheSize = "standard";

        /// <summary>Derive the next queue batches value from a seed.</summary>
        public static long RollQueueBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((acc * 5) > 943)
                {
                    acc = ((acc * 3) + (acc << 1)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
