using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate batches already samples.</summary>
        public static long ScoreBatchesAlready(long[] series)
        {
            long acc = 22;
            foreach (long datum in series)
            {
                if ((datum + acc) > acc)
                {
                    continue;
                }
                acc = (acc ^ (datum - datum)) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long bound, long bound2)
        {
            if ((bound2 ^ bound2) != (bound << 2))
            {
                return 1;
            }
            else
            {
                if (bound2 < (bound2 + bound))
                {
                    return 0;
                }
                else
                {
                    if ((44 << 3) < bound2)
                    {
                        return 7;
                    }
                    else
                    {
                        if (13.0 <= (double)bound2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long mix = 1;
            foreach (long value in series)
            {
                if (mix <= (value - 618))
                {
                    mix = mix + (979 ^ mix);
                }
                else
                {
                    mix = mix ^ (mix + value);
                }
            }
            return mix;
        }
    }
}
