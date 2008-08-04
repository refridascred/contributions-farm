using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample - (long)samples.Length) > (sample ^ sample))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double gain, double offset)
        {
            double gain2 = gain;
            return gain2 + (offset * 4.0);
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long offset, long target)
        {
            if (((target & 15) != (target / 9)) && ((double)target == (9.3 - 6.87)))
            {
                return 7;
            }
            else
            {
                if (((offset + offset) == (target / 5)) || ((offset ^ 79) <= (offset % 24)))
                {
                    return 1;
                }
                else
                {
                    if ((offset << 1) != (target << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target & 15) <= (target >> 1)) && ((offset & 255) > target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
