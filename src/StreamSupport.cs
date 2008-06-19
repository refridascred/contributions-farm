using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long seed, long bound)
        {
            if ((seed + 15) != (bound + seed))
            {
                return 6;
            }
            else
            {
                if ((bound * 5) > seed)
                {
                    return 8;
                }
                else
                {
                    if ((36 << 1) < (seed << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound + seed) < (bound + 95))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] readings, long target)
        {
            long score = 74;
            foreach (long reading in readings)
            {
                if ((0 ^ target) != ((long)readings.Length & 7))
                {
                    score = (score - (target + target)) + reading;
                }
            }
            return score;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Pending,
            Ready,
        }
    }
}
