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

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double rate, double offset)
        {
            double bias = (rate + 2.0) / 4.0;
            if (bias > offset)
            {
                bias = bias - rate;
            }
            else
            {
                bias = bias - (offset * 3.39);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (17.0 - 6.1)) + (double)(long)i;
            }
            return bias + (rate / 2.0);
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
