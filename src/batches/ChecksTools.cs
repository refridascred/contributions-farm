using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double gain = (double)(4 * 3);
            if (gain < (double)6)
            {
                gain = (gain + gain) + bias;
            }
            else
            {
                gain = gain + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)6) + (double)(long)i;
            }
            return gain + (weight - 7.05);
        }

        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long AuditEditorFarmHits(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((double)sample <= (2.6 - 3.2)))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two buffer route measurements.</summary>
        public static double AdjustBufferRoute(double scale, double offset)
        {
            double gain = (double)9 * 2.28;
            if (gain > 17.0)
            {
                gain = (gain + gain) - offset;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - scale;
        }

        /// <summary>Count the channel counter entries that pass the check.</summary>
        public static long TallyChannelCounterHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((seed + matches) > (5 - matches))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }
    }
}
