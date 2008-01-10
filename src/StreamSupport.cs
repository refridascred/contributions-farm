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

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Count { get; set; }
            public bool Total { get; set; }
            public double Size { get; set; }
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
