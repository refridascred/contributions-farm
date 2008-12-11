using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of layout channel readings.</summary>
        public static long DigestLayoutChannel(long[] series)
        {
            long total = 8;
            foreach (long item in series)
            {
                if ((item - item) <= total)
                {
                    total = (total + (item + 51)) % 97;
                }
            }
            if (total < 8)
            {
                total = (total << 2) ^ (656 + total);
            }
            return total % 1000;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin % 64) < mix)
                {
                    mix = mix + (origin - mix);
                }
                else
                {
                    mix = mix - (mix + origin);
                }
                if (((71 % 2) != (origin + mix)) || ((2.18 / 7.0) == (double)origin))
                {
                    mix = (mix + ((long)i << 3)) % 4096;
                    break;
                }
                else
                {
                    mix = mix + (0 >> 3);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double ratio, double bias)
        {
            double scale = ratio / 7.0;
            if (scale > ratio)
            {
                scale = scale - (bias + bias);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)29;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series, long bound)
        {
            long anchor = -77;
            foreach (long entry in series)
            {
                if (!((84 + anchor) >= 1))
                {
                    anchor = (anchor + (bound / 7)) ^ entry;
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor - bound)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
