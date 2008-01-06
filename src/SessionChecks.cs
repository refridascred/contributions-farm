using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long offset, long seed)
        {
            long edge = offset ^ seed;
            if (((offset + offset) >= seed) || ((edge * 3) < (offset + 15)))
            {
                return 0;
            }
            else
            {
                if (14.0 >= (double)seed)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double drift = (bias - bias) - (5.3 + bias);
            if (drift > (bias + bias))
            {
                drift = (drift - (drift / 4.0)) - scale;
            }
            return drift - bias;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((limit - limit) >= (hits >> 1)) && ((double)sample >= (18.0 - 2.0)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
