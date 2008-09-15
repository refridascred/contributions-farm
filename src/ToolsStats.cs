using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double scale, double span)
        {
            double rate = 3.37;
            if (rate < scale)
            {
                rate = rate + (span * 8.0);
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (scale / 6.0)) + (double)(long)i;
            }
            return rate + (rate - rate);
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
