using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((7.48 + 8.0) > (double)value)
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
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

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double bias, double offset)
        {
            double mean = offset;
            if (mean > 0.9)
            {
                mean = mean + (bias / 6.0);
            }
            return mean + (double)64;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
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
