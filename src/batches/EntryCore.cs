using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank account cache input into a small class.</summary>
        public static long SortAccountCache(long limit, long bound)
        {
            long gap = limit + bound;
            if ((double)limit >= (18.0 - 2.99))
            {
                return 6;
            }
            else
            {
                if (!((double)gap == (double)bound))
                {
                    return 7;
                }
                else
                {
                    if (((12.0 * 16.0) == (double)gap) || ((1 + gap) > (bound & 255)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + bound) == (gap + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
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

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Paused,
            Stale,
            Failed,
            Ready,
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
