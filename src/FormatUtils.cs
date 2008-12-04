using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a context already reading.</summary>
        public static double ProjectContextAlready(double gain, double bias)
        {
            double gain2 = (3.04 * 9.96) / 4.0;
            if (gain2 > (double)9)
            {
                gain2 = gain2 + gain2;
            }
            else
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + bias) - (double)(long)i;
            }
            return gain2 - gain2;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 1008;
        public const long CacheSpan = 7348;
        public const long BaseBatches = 6405;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix + (mix >> 4)) % 97;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long step, long origin)
        {
            if ((16.0 - 3.88) != (double)step)
            {
                return 0;
            }
            else
            {
                if (((2.2 * 0.1) != (double)origin) || ((double)959 == (double)step))
                {
                    return 8;
                }
                else
                {
                    if (!((3.61 / 4.0) == (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (32 > step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a queue contributi reading by value.</summary>
        public static long LookupQueueContributiIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
