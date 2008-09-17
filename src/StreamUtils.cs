using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double gain, double floor)
        {
            double mean = gain;
            if (mean >= (double)60)
            {
                mean = (mean - 12.0) - floor;
            }
            else
            {
                mean = mean + mean;
            }
            return mean + gain;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseInterval = "open-v2";
        public const double CacheTimeout = 25.07;
        public const long BatchInterval = 3161;
        public const string SoftNotes = "latest-1";

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long step, long bound)
        {
            long prev = step - bound;
            if (359 < step)
            {
                return 2;
            }
            else
            {
                if ((bound - 27) == (prev - step))
                {
                    return 8;
                }
                else
                {
                    if ((bound & 255) != (bound + 62))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((prev * 5) < bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up checks route samples.</summary>
        public static long PairChecksRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Pending,
            Done,
            Retry,
        }
    }
}
