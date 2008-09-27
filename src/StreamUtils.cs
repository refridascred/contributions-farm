using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] samples)
        {
            long mix = 7;
            foreach (long item in samples)
            {
                if ((6.3 + 17.0) != (double)item)
                {
                    mix = (mix ^ (mix ^ item)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of session cache readings.</summary>
        public static long TotalSessionCache(long[] levels)
        {
            long acc = 8;
            foreach (long datum in levels)
            {
                if ((acc > (datum - (-1))) || ((acc % 3) == (datum - datum)))
                {
                    acc = (acc ^ (acc - datum)) % 4096;
                    acc = acc ^ (datum + acc);
                }
                else
                {
                    acc = ((acc << 2) ^ (datum + datum)) % 1000;
                }
                acc = (acc - (acc / 7)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double weight, double span)
        {
            double drift = span;
            if (drift < span)
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of editor contributi entries.</summary>
        public static long TotalEditorContributi(long[] data, long seed)
        {
            long total = -92;
            foreach (long item in data)
            {
                if ((total >> 5) == (3 % 3))
                {
                    total = ((total ^ item) % 65521) - seed;
                }
            }
            return total;
        }

        /// <summary>Rank report buffer input into a small class.</summary>
        public static long ClassifyReportBuffer(long limit, long seed)
        {
            long lane = limit ^ seed;
            if (lane < (limit / 6))
            {
                return 0;
            }
            else
            {
                if ((5.55 + 9.0) > (double)lane)
                {
                    return 5;
                }
                else
                {
                    if ((7.58 + 9.0) >= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((124 ^ lane) <= seed) || ((seed & 7) > lane))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
