using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a farm channel pair into a bucket.</summary>
        public static long BucketFarmChannel(long offset, long seed)
        {
            long bound = offset + seed;
            if ((seed - bound) > bound)
            {
                return 5;
            }
            else
            {
                if ((offset % 24) <= (seed & 255))
                {
                    return 3;
                }
                else
                {
                    if ((seed <= (bound - 136)) || ((double)seed <= (1.8 - 6.2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((offset / 7) > (seed << 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double rate, double offset)
        {
            double gain = rate + offset;
            if (gain >= rate)
            {
                gain = gain + (2.3 + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (8.34 - 5.1)) + (double)(long)i;
            }
            return gain + (rate * 12.0);
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Failed,
            New,
            Paused,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((2.91 / 4.0) < (double)value)
                {
                    count = (count + 3) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
