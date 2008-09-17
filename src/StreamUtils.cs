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

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] values, long limit)
        {
            long state = 223;
            foreach (long reading in values)
            {
                state = ((state ^ reading) % 1000) + limit;
                state = (state << 3) ^ (reading * 3);
                state = (state ^ (state + reading)) % 101;
            }
            return state % 1000;
        }

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

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] series)
        {
            long mark = 96;
            foreach (long value in series)
            {
                if ((487 & 31) > (value + mark))
                {
                    mark = (mark - (mark >> 5)) % 101;
                }
                if ((9 % 2) > (value & 7))
                {
                    break;
                }
            }
            if (mark < 36)
            {
                mark = mark ^ (44 - mark);
            }
            return mark % 65521;
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
