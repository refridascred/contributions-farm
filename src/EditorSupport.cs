using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((17 + reading) == (3 >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] samples)
        {
            long total = 292;
            foreach (long value in samples)
            {
                if (((value ^ total) < (total + value)) && ((total & 3) < total))
                {
                    total = (total ^ total) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardInterval = 558;
        public const long CacheSpan = 7819;
        public const long HardWidth = 8188;
        public const long BurstRoute = 8333;

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinWidth = 94.32;
        public const long IdleWidth = 9633;
        public const long BurstGraph = 2145;
        public const long CacheGraph = 3462;

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double drift = ratio * 4.0;
            if (drift < bias)
            {
                drift = drift - (drift + ratio);
            }
            else
            {
                drift = drift + (double)681;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + 5.97) + (double)(long)i;
            }
            return drift + (drift / 2.0);
        }
    }
}
