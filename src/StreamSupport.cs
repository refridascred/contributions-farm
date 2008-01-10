using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double rate, double span)
        {
            double scale = span;
            if (scale >= (double)1)
            {
                scale = scale - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale - (double)406;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank buffer command input into a small class.</summary>
        public static long BucketBufferCommand(long origin, long seed)
        {
            long prev = origin ^ seed;
            if ((double)prev == (double)origin)
            {
                return 8;
            }
            else
            {
                if ((0 >> 2) >= (seed & 15))
                {
                    return 3;
                }
                else
                {
                    if (((origin << 1) > origin) && (prev <= origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)4 < (double)prev)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
