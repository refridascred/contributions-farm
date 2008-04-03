using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Offset { get; set; }
            public double Count { get; set; }
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((target & 255) > (target % 5)))
                {
                    mix = ((mix * 2) + (-1)) % 255;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (((mix << 2) ^ (target << 2)) % 65521) ^ (long)i2;
                    mix = (mix << 3) ^ ((long)i + (long)i);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double bias = (offset * 17.0) / 7.0;
            if (bias > 0.59)
            {
                bias = (bias - (offset / 6.0)) - gain;
            }
            return bias + 0.91;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((9 + hits) != (value + floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
