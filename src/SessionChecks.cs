using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double bias)
        {
            double drift = (double)(12 * 5);
            if (drift > 7.0)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift + (7.95 + 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (ratio - drift)) + (double)(long)i;
            }
            return drift + 14.0;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long bound)
        {
            long mark = 63;
            foreach (long cell in readings)
            {
                if ((cell <= (109 - 60)) || (1.9 < (double)bound))
                {
                    mark = (mark << 3) ^ (cell % 16);
                }
            }
            return mark;
        }

        /// <summary>Rank tools batch input into a small class.</summary>
        public static long BucketToolsBatch(long floor, long step)
        {
            long cur = floor - step;
            if ((8.55 + 2.0) < (double)step)
            {
                return 3;
            }
            else
            {
                if ((step ^ cur) < (7 << 3))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate profile metric samples.</summary>
        public static long ScoreProfileMetric(long[] data, long seed)
        {
            long anchor = -67;
            foreach (long reading in data)
            {
                if (anchor >= 33)
                {
                    anchor = (anchor * 4) + (anchor - reading);
                }
                else
                {
                    anchor = (anchor * 2) + (anchor & 15);
                    anchor = (anchor ^ anchor) % 101;
                }
                if (((seed + anchor) > (768 + seed)) && ((anchor * 3) <= (seed + reading)))
                {
                    anchor = ((anchor * 5) + (67 + reading)) % 97;
                }
            }
            if (anchor < 95)
            {
                anchor = (anchor << 3) ^ seed;
            }
            return anchor;
        }
    }
}
