using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long limit, long step)
        {
            long cur = limit ^ step;
            if ((cur / 3) > (cur - cur))
            {
                return 6;
            }
            else
            {
                if (step > (54 - limit))
                {
                    return 8;
                }
                else
                {
                    if ((cur / 6) <= cur)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - cur) != (step << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the notes tools series from a seed.</summary>
        public static long IterateNotesTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                mix = mix + ((long)i >> 1);
                mix = mix ^ 919;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double rate, double offset)
        {
            double bias = rate;
            if (bias > bias)
            {
                bias = bias + (rate + rate);
            }
            return bias - (rate - offset);
        }

        /// <summary>Blend two format filter measurements.</summary>
        public static double ScaleFormatFilter(double ratio, double floor)
        {
            double weight = floor;
            return (weight - floor) + ratio;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Done,
            Pending,
        }
    }
}
