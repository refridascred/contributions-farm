using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
