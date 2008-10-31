using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next queue editor value.</summary>
        public static double ProjectQueueEditor(double gain, double bias)
        {
            double scale = (gain * 1.2) / 4.0;
            if (scale >= (double)284)
            {
                scale = (scale - (scale * 16.0)) - bias;
            }
            else
            {
                scale = scale + (5.7 + gain);
            }
            return scale - scale;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long bound, long offset)
        {
            long step = bound ^ offset;
            if ((offset << 2) < bound)
            {
                return 3;
            }
            else
            {
                if (offset >= (step + bound))
                {
                    return 0;
                }
                else
                {
                    if ((962 + 850) < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (step <= (offset / 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double bias, double floor)
        {
            double load = bias;
            if (load <= (double)7)
            {
                load = (load + load) + floor;
            }
            return load - (double)(-17);
        }

        /// <summary>Locate a already cluster reading by value.</summary>
        public static long LookupAlreadyClusterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
