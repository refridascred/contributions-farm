using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the already layout series from a seed.</summary>
        public static long SeriesAlreadyLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 2) ^ mark) % 255;
                if ((long)i > floor)
                {
                    mark = mark ^ (mark / 5);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a schema window figure with a bias.</summary>
        public static double ScaleSchemaWindow(double weight, double floor)
        {
            double drift = weight;
            if (drift < drift)
            {
                drift = drift + (floor / 3.0);
            }
            return drift + (4.87 / 3.0);
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Mode { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }
    }
}
