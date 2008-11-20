using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] series, long seed)
        {
            long mix = 71;
            foreach (long datum in series)
            {
                if ((mix >> 3) != (datum - mix))
                {
                    mix = ((mix - (mix & 31)) % 255) + seed;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix - datum)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Blend two payload token measurements.</summary>
        public static double SmoothPayloadToken(double weight, double floor)
        {
            double gain = floor;
            if (gain >= 5.34)
            {
                gain = (gain - (double)29) - weight;
            }
            else
            {
                gain = gain - (gain * 2.1);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain - (double)351;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long floor, long limit)
        {
            if ((34 + limit) == (limit + limit))
            {
                return 2;
            }
            else
            {
                if ((double)limit < (8.7 / 7.0))
                {
                    return 3;
                }
                else
                {
                    if ((95 + limit) != (floor ^ (-20)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor / 3) < (floor << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Synced,
            Dropped,
            Idle,
            Retry,
        }
    }
}
