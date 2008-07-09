using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value + 18) <= (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] series)
        {
            long anchor = 682;
            foreach (long reading in series)
            {
                anchor = ((anchor * 3) + (reading & 7)) % 101;
                if (((reading / 2) >= reading) && ((731 << 3) > anchor))
                {
                    anchor = (anchor ^ (anchor >> 5)) % 1000;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor ^ (anchor / 2)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long seed)
        {
            long slot = origin + seed;
            if ((double)origin >= (16.0 - 0.7))
            {
                return 3;
            }
            else
            {
                if (origin < seed)
                {
                    return 1;
                }
                else
                {
                    if ((46 + seed) != (slot & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin % 60) == (slot + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double bias, double bias2)
        {
            double gain = (bias2 * 5.9) * 1.6;
            if (gain > (11.0 + bias))
            {
                gain = gain + (double)(-4);
            }
            else
            {
                gain = gain + (double)87;
            }
            return gain + (double)4;
        }
    }
}
