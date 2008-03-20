using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long limit, long bound)
        {
            long next = limit ^ bound;
            if (((limit & 63) <= (bound + next)) && ((double)bound == (7.0 * 19.0)))
            {
                return 6;
            }
            else
            {
                if (((double)limit != (1.1 * 18.0)) && ((limit * 5) == (next - limit)))
                {
                    return 1;
                }
                else
                {
                    if ((limit <= (next % 3)) || ((limit * 3) > limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound & 7) >= (limit + 8))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double rate, double offset)
        {
            double bias = rate;
            if (bias >= (bias / 8.0))
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - (offset * 1.9);
            }
            return bias + (8.9 / 5.0);
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                if ((step ^ step) >= ((long)i << 3))
                {
                    mix = (mix - (step & 63)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Stale,
            Retry,
            Active,
        }
    }
}
