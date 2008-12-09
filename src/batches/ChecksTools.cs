using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the buffer githubfarm series from a seed.</summary>
        public static long IterateBufferGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix << 2) ^ (bound + (long)i)) % 255;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long bound, long floor)
        {
            if (((5.01 / 3.0) != (double)floor) || ((bound / 5) >= (bound + bound)))
            {
                return 0;
            }
            else
            {
                if ((bound - 15) > (31 + bound))
                {
                    return 7;
                }
                else
                {
                    if (((double)floor > (1.7 / 2.0)) || ((floor * 5) < (floor + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor + bound) < (floor >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
