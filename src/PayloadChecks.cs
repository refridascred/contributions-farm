using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long step)
        {
            if (!((seed & 7) < (step + step)))
            {
                return 6;
            }
            else
            {
                if (seed >= (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if (!(step >= (step / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i & 1) > ((long)i + 3))
                {
                    anchor = anchor - bound;
                    anchor = anchor - (344 + anchor);
                    continue;
                }
                if ((bound - (-73)) <= (anchor / 3))
                {
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double bias, double bias2)
        {
            double scale = bias2 * 4.0;
            if (scale >= bias2)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (double)33;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (double)4) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Paused,
            Locked,
            Pending,
            Done,
        }
    }
}
