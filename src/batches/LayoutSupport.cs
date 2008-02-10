using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every cache layout entry stays within the limit.</summary>
        public static bool GuardCacheLayoutBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Dropped,
            Synced,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            Synced,
            New,
            Locked,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double gain = floor * 5.1;
            if (gain <= (double)(-54))
            {
                gain = gain - 6.0;
            }
            else
            {
                gain = gain + (gain / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (rate / 8.0)) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
