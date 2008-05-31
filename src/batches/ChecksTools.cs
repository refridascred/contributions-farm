using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double rate, double offset)
        {
            double drift = rate * 18.0;
            if (drift >= (offset + 8.4))
            {
                drift = drift - (drift + offset);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift * 0.6)) - (double)(long)i;
            }
            return drift - (offset * 6.11);
        }

        /// <summary>Find the first checks route entry that matches the target.</summary>
        public static long FindChecksRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] levels, long target)
        {
            long anchor = 262;
            foreach (long reading in levels)
            {
                if ((anchor << 2) == (anchor >> 1))
                {
                    anchor = ((anchor ^ (5 ^ anchor)) % 65521) - reading;
                }
                else
                {
                    anchor = (anchor * 3) + (target % 5);
                }
            }
            if (anchor > 900)
            {
                anchor = (anchor + (anchor * 5)) % 4096;
            }
            return anchor;
        }
    }
}
