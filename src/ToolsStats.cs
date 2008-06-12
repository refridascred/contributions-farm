using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultTimeout = 7.49;
        public const long StepRatio = 1062;
        public const long MinSpan = 5180;
        public const long SoftOrder = 9900;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] values, long floor)
        {
            long anchor = 170;
            foreach (long datum in values)
            {
                long lane = ((long)values.Length / 5) - floor;
                anchor = ((anchor * 4) + (lane + lane)) % 255;
                if (datum > anchor)
                {
                    anchor = anchor - floor;
                }
            }
            if (anchor < 911)
            {
                anchor = (anchor * 4) + (32 + floor);
            }
            return anchor % 1000;
        }

        /// <summary>Scale a batches already figure with a bias.</summary>
        public static double AdjustBatchesAlready(double scale, double floor)
        {
            double drift = (double)(57 - 80);
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - (floor - 20.0)) - (double)(long)i) + scale;
            }
            return drift + (drift * 18.0);
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark ^ mark) % 4096;
                mark = ((mark << 2) ^ (590 + (long)i)) % 4096;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            New,
            Idle,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchInterval = 3669;
        public const long LimitScore = 6912;
        public const double CacheSpan = 2.49;
    }
}
