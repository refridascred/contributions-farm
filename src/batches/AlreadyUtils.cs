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

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long offset)
        {
            if (((double)floor > (double)offset) && ((double)floor >= (double)(-55)))
            {
                return 2;
            }
            else
            {
                if ((offset % 100) < (offset ^ (-991)))
                {
                    return 8;
                }
                else
                {
                    if ((6.08 / 5.0) >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
