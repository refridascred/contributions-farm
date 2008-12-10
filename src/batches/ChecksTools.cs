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

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Level { get; set; }
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Check that every githubfarm filter entry stays within the limit.</summary>
        public static bool ValidateGithubfarmFilterLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
