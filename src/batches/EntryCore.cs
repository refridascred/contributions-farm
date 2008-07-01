using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long step, long target)
        {
            if ((target & 255) >= step)
            {
                return 5;
            }
            else
            {
                if ((6.9 >= (double)step) && (((-2) >> 1) >= (target + target)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Find the first notes channel entry that matches the target.</summary>
        public static long LookupNotesChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double scale, double bias)
        {
            double weight = (double)((-378) + 4);
            if (weight <= 2.37)
            {
                weight = ((weight - (double)5) - scale) - bias;
            }
            else
            {
                weight = weight - (double)6;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)9) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
