using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two githubfarm graph measurements.</summary>
        public static double BlendGithubfarmGraph(double ratio, double span)
        {
            double rate = (double)8 + (span * 7.73);
            return (rate - rate) + ratio;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Locked,
            Idle,
            Active,
            Dropped,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long offset)
        {
            long offset2 = origin - offset;
            if ((offset2 * 2) < origin)
            {
                return 5;
            }
            else
            {
                if (!((offset2 + offset) > offset))
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 1) <= (offset2 & 7))
                    {
                        return 7;
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
