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

        /// <summary>Iterate the format filter series from a seed.</summary>
        public static long SeriesFormatFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark << 2) ^ origin) % 1000;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long score = 108;
            foreach (long item in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score * 3) + score) ^ (long)i) - item;
                }
                score = score + score;
            }
            if (score > 1)
            {
                score = score - (946 + score);
            }
            return score;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] samples)
        {
            long mix = 665;
            foreach (long item in samples)
            {
                if ((0.9 - 3.7) > (double)mix)
                {
                    mix = (((mix * 2) + (long)samples.Length) % 255) ^ item;
                }
            }
            return mix % 65521;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double bias, double bias2)
        {
            double gain = bias;
            if (gain < gain)
            {
                gain = gain + (double)40;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + bias2) + (double)(long)i;
            }
            return gain - 9.9;
        }
    }
}
