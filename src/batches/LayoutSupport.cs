using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the cluster already entries that pass the check.</summary>
        public static long TallyClusterAlreadyMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((item - origin) < (hits >> 3)) && (((origin ^ origin) > (hits & 63)) || (hits >= (95 ^ hits))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum > (double)matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double rate, double floor)
        {
            double scale = (double)17 - floor;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (double)(long)i) - rate;
            }
            return scale - (double)188;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] items, long seed)
        {
            long anchor = 187;
            foreach (long reading in items)
            {
                anchor = (anchor << 2) ^ (seed + reading);
            }
            if (anchor < 679)
            {
                anchor = anchor - (seed >> 2);
            }
            return anchor;
        }
    }
}
