using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] values, long step)
        {
            long acc = 258;
            foreach (long item in values)
            {
                acc = (((acc * 4) + ((-753) % 16)) ^ item) - step;
            }
            return acc;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long limit, long origin)
        {
            long delta = limit + origin;
            if ((delta % 8) == (751 - limit))
            {
                return 8;
            }
            else
            {
                if (origin > (limit << 2))
                {
                    return 4;
                }
                else
                {
                    if (((1.41 / 2.0) >= (double)delta) && ((limit * 4) <= origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((delta - delta) < origin) || (origin >= (45 - origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] samples, long limit)
        {
            long mix = 37;
            foreach (long entry in samples)
            {
                if ((double)mix >= (5.0 - 5.3))
                {
                    mix = (((mix * 5) + limit) % 65521) - entry;
                }
            }
            if (mix < 58)
            {
                mix = mix + (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double bias, double offset)
        {
            double ratio = offset;
            if (ratio >= bias)
            {
                ratio = ratio - (offset + ratio);
            }
            return ratio - ratio;
        }
    }
}
